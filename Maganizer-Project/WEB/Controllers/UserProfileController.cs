using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.WEB.Models;
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
        [Route("MyProfile")]
        public IActionResult GetMyProfile()
        {
            UserProfileDTO profileInfo = profileService.GetProfile(User.Identity.Name);
            if(profileInfo == null)
            {
                return View("ErrorNotFound");
            }

            var profileViewModel = new UserProfileViewModel()
            {
                Username = profileInfo.Username,
                Email = profileInfo.Email,
                PhoneNumber = profileInfo.PhoneNumber,
                WebSiteUrl = profileInfo.WebSiteUrl,
                Country = profileInfo.Country,
                City = profileInfo.City,
                Street = profileInfo.Street,
                About = profileInfo.About,
                FullName = profileInfo.FirstName + " " + profileInfo.LastName,
                Avatar = profileInfo.Avatar,
            };


            return View("UserProfile", profileViewModel);   
        }

        //TODO
        //[Route("Users")]
        //GetProfile

        //GET
        [Route("EditProfile")]
        [HttpGet]
        public IActionResult EditProfile()
        {            
            UserProfileDTO profileInfo = profileService.GetProfile(User.Identity.Name);
            if(profileInfo == null)
            {
                return View("ErrorNotFound");
            }

            var editProfileViewModel = new EditUserProfileViewModel()
            {
                Username = profileInfo.Username,
                Email = profileInfo.Email,
                PhoneNumber = profileInfo.PhoneNumber,
                WebSiteUrl = profileInfo.WebSiteUrl,
                Country = profileInfo.Country,
                City = profileInfo.City,
                Street = profileInfo.Street,
                About = profileInfo.About,
                FirstName = profileInfo.FirstName,
                LastName = profileInfo.LastName,
                OldAvatar = profileInfo.Avatar,
            };

            return View("EditUserProfile", editProfileViewModel);
        }

        [Route("EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditUserProfileViewModel editProfileModel)
        {  
            EditUserProfileDTO editProfileDTO = new EditUserProfileDTO()
            {
                Username = User.Identity.Name,
                FirstName = editProfileModel.FirstName,
                LastName = editProfileModel.LastName,
                PhoneNumber = editProfileModel.PhoneNumber,
                WebSiteUrl = editProfileModel.WebSiteUrl,
                Country = editProfileModel.Country,
                City = editProfileModel.City,
                Street = editProfileModel.Street,
                About = editProfileModel.About,
                NewAvatar = editProfileModel.NewAvatar,
                OldAvatar = editProfileModel.OldAvatar
            };

            profileService.UpdateProfile(editProfileDTO);
       
            return RedirectToAction("GetMyProfile");
        }

    }
}
