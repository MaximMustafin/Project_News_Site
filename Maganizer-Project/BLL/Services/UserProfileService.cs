using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.Services
{
    public class UserProfileService : IUserProfileService
    {
        IUnitOfWork DataBase { get; set; }
        
        public UserProfileService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }

        public UserProfileDTO GetProfile(string username)
        {
            var accountResult = DataBase.Accounts.GetByName(username);

            if(accountResult.Result == null)
            {
                return null;
            }

            var userProfiles = DataBase.UserProfiles.GetAll();

            var userProfile = userProfiles.FirstOrDefault(x => x.ApplicationUserId == accountResult.Result.Id);
            
            return new UserProfileDTO()
            {
                Id = userProfile.Id,
                Username = accountResult.Result.UserName,
                Email = accountResult.Result.Email,
                About = userProfile.About,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                PhoneNumber = accountResult.Result.PhoneNumber,
                WebSiteUrl = userProfile.WebSiteUrl,
                Country = userProfile.Country,
                City = userProfile.City,
                Street = userProfile.Street,
                Avatar = userProfile.Avatar
            };

        }
        public void UpdateProfile(EditProfileDTO editProfileDTO)
        {
            UserProfile userProfile = new UserProfile()
            {
                Id = editProfileDTO.Id,
                FirstName = editProfileDTO.FirstName,
                LastName = editProfileDTO.LastName,
                Country = editProfileDTO.Country,
                City = editProfileDTO.City,
                Street = editProfileDTO.Street,
                About = editProfileDTO.About,
                WebSiteUrl = editProfileDTO.WebSiteUrl,
                Avatar = editProfileDTO.Avatar
            };

            DataBase.UserProfiles.Update(userProfile);
            DataBase.Save();
        }


    }
}
