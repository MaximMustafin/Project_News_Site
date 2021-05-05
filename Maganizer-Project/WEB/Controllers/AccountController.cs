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

                    return View("SignUp", signUpModel);
                }

                return View("SignIn");
                
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
                }

            }
            
            return View("SignIn", signInModel);
        }

        //POST
        [Route("SignOut")]
        public async Task<IActionResult> SignOut()
        {
            await accountService.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
