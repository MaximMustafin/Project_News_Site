using Microsoft.AspNetCore.Mvc;
using Maganizer_Project.BLL.Interfaces;
using System.Threading.Tasks;
using Maganizer_Project.WEB.Models;
using Maganizer_Project.BLL.DTO;
using System;
using Microsoft.AspNetCore.Http;

namespace Maganizer_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        //GET
        [Route("signIn")]
        public IActionResult signIn()
        {
            return View("SignIn");
        }

        //GET
        [Route("signUp")]
        public IActionResult signUp()
        {
            return View("SignUp");
        }

        //POST
        [Route("signUp")]
        [HttpPost]
        public async Task<IActionResult> signUp(SignUpViewModel signUpModel)
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

                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("SignUp", signUpModel);
                }

                return View("SignIn");
                
            }

            return View("SignUp", signUpModel);
        }

        //POST
        [Route("signIn")]
        [HttpPost]
        public async Task<IActionResult> signIn(SignInViewModel signInModel, string RememberMe)
        {
            if (ModelState.IsValid)
            {
                bool RememberMeBool = false;

                if (RememberMe == "on")
                {
                    RememberMeBool = true;
                }

                var signInDTO = new SignInUserDTO()
                {
                    Username = signInModel.Username,
                    Password = signInModel.Password,
                    RememberMe = RememberMeBool
                };

                var result = await accountService.SignInAsync(signInDTO);                          

                if (result.Succeeded)
                {
                    return View("SignIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password are wrong. Please try again");
                }

            }
            
            return View("SignIn", signInModel);
        }

        //POST
        public async Task<IActionResult> SignOut()
        {
            await accountService.SignOutAsync();
            return RedirectToAction("Index", "UserProfile");
        }
    }
}
