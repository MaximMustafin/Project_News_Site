using Microsoft.AspNetCore.Mvc;
using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using System.Threading.Tasks;
using Maganizer_Project.WEB.Models;

namespace Maganizer_Project.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }
        [Route("signInUp")]
        public IActionResult SignInUp()
        {
            return View("SignInUp");
        }

        [Route("signUp")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignInUpViewModel SignInUpModel)
        {
            if (ModelState.IsValid)
            {
                var result = await accountService.CreateUserAsync(SignInUpModel.SignUpUser);
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }               
            }

            return View("SignInUp");
        }

        [Route("signIn")]
        [HttpPost]
        public IActionResult SignIn(SignInUpViewModel SignInUpModel, string RememberMe)
        {
            if (ModelState.IsValid)
            {
                //some code
            }

            return View("SignInUp");
        }
    }
}
