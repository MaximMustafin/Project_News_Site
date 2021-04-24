using Microsoft.AspNetCore.Mvc;
using Maganizer_Project.BLL.Interfaces;
using System.Threading.Tasks;
using Maganizer_Project.WEB.Models;
using Maganizer_Project.BLL.DTO;
using System;

namespace Maganizer_Project.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;
        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        //GET
        [Route("SignIn")]
        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        //GET
        [Route("SignUp")]
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

                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }               
            }

            return View("SignUp", signUpModel);
        }

        //POST
        [Route("SignIn")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signInModel, string RememberMe)
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
                    Console.WriteLine("Sign In is successful!");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password are wrong. Please try again");
                }

            }
            

            return View("SignIn", signInModel);
        }
    }
}
