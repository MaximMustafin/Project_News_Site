using Microsoft.AspNetCore.Mvc;
using Maganizer_Project.BLL.Interfaces;
using System.Threading.Tasks;
using Maganizer_Project.WEB.Models;
using Maganizer_Project.BLL.DTO;
using NETCore.MailKit.Core;

namespace Maganizer_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly IEmailService emailService;
        public AccountController(IAccountService accountService, IEmailService emailService)
        {
            this.accountService = accountService;
            this.emailService = emailService;
        }

        //GET
        [Route("SignIn")]
        [HttpGet]
        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        //GET
        [Route("SignUp")]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }

        //POST
        [Route("SignUp")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                var signUpDTO = new SignUpUserDTO()
                {
                    Username = signUpModel.Username,
                    Email = signUpModel.Email,
                    Password = signUpModel.Password,
                };

                var result = await accountService.CreateUser(signUpDTO);

                if (!result.Result.Succeeded)
                {
                    foreach(var error in result.Result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("SignUp", signUpModel);
                }

                //email verification
                var code = result.VerificationCode;
                var verificationLink = Url.Action(nameof(VerifyEmail), "Account", new { userId = result.UserId, code}, Request.Scheme, Request.Host.ToString());
                await emailService.SendAsync(result.Email, "Maganizer account verification",  $"<p>Hi {result.Username},</p>" +
                    $"<p>You can visit this link below to finish verification:</p>" +
                    $"<a href=\"{verificationLink}\">Verify Email</a>" +
                    $"<p>If you did not request this, please REPLY IMMEDIATELY as your account may be in danger.</p>", true);

                return RedirectToAction("EmailVerification");              
            }

            return View("SignUp", signUpModel);
        }

        [Route("VerifyEmail")]
        public async Task<IActionResult> VerifyEmail(string userId, string code)
        {
            var result = await accountService.ConfirmEmail(userId, code);

            if (result != null && result.Succeeded)
            {
                return View();
            }

            return BadRequest();
        }

        [Route("EmailVerification")]
        public IActionResult EmailVerification() => View("EmailVerification");

        //POST
        [Route("SignIn")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signInModel, string RememberMe)
        {
            if (ModelState.IsValid)
            {               
                var signInDTO = new SignInUserDTO()
                {
                    Username = signInModel.Username,
                    Password = signInModel.Password,
                    RememberMe = RememberMe
                };

                var result = await accountService.SignInAsync(signInDTO);                          

                if (result.Succeeded)
                {
                    return View("SignIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password are wrong. Please try again");
                    ModelState.AddModelError("", "Your email can be not verified. Please check and verify your email before to sign in");
                }

            }
            
            return View("SignIn", signInModel);
        }

        //POST
        [Route("SignOut")]
        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await accountService.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
