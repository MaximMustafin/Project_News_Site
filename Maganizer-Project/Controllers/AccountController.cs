using Microsoft.AspNetCore.Mvc;
using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using System.Threading.Tasks;

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

        [Route("signInUp")]
        [HttpPost]
        public async Task<IActionResult> SignInUp(SignUpUserDTO signUpModel)
        {
            if (ModelState.IsValid)
            {
                var result = await accountService.CreateUserAsync(signUpModel);
                if (!result.Succeeded)
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                //ModelState.Clear();
            }

            return View("SignInUp");
        }
    }
}
