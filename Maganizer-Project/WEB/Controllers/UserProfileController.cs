using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

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
        [Route("users")]
        [HttpGet("{username}")]
        public IActionResult Index(string username)
        {
            if(username == null)
            {
                return View("ErrorNotFound");
            }

            UserProfileDTO profileInfo = profileService.GetProfile(username);

            if(profileInfo == null)
            {
                return View("ErrorNotFound");
            }

            var profileViewModel = new UserProfileViewModel()
            {
                Id = profileInfo.Id,
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

        //GET
        [Route("UpdateProfile")]
        [HttpGet("{username}")]
        public IActionResult EditProfile(string username)
        {
            if(User.Identity.Name != username)
            {
                return View("ErrorNotFound");
            }
            UserProfileDTO profileInfo = profileService.GetProfile(username);

            var editProfileViewModel = new EditUserProfileViewModel()
            {
                Id = profileInfo.Id,
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

        [Route("UpdateProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditUserProfileViewModel editProfileModel)
        {
            byte[] imageData = null;
            byte[] newAvatar;
            if (editProfileModel.NewAvatar != null)
            {
                using (var binaryReader = new BinaryReader(editProfileModel.NewAvatar.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)editProfileModel.NewAvatar.Length);
                }
               newAvatar = imageData;
            }
            else
            {
                newAvatar = editProfileModel.OldAvatar;
            }

            EditProfileDTO editProfileDTO = new EditProfileDTO()
            {
                Id = editProfileModel.Id,
                FirstName = editProfileModel.FirstName,
                LastName = editProfileModel.LastName,
                PhoneNumber = editProfileModel.PhoneNumber,
                WebSiteUrl = editProfileModel.WebSiteUrl,
                Country = editProfileModel.Country,
                City = editProfileModel.City,
                Street = editProfileModel.Street,
                About = editProfileModel.About,
                Avatar = newAvatar
            };

            profileService.UpdateProfile(editProfileDTO);
       
            return RedirectToAction("Index", editProfileModel.Username);
        }

    }
}
