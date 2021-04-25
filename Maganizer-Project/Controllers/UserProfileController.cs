using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maganizer_Project.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        IUserProfileService profileService;
        public UserProfileController(IUserProfileService profileService)
        {
            this.profileService = profileService;
        }
        
        //GET
        [Route("Profile")]
        public IActionResult Index()
        {
            return View("UserProfile");
        }

        //TODO
        ////GET
        //[Route("EditUserProfile")]
        //public IActionResult EditUserProfile()
        //{
            
        //}
    }
}
