using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Infrastructure;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System.IO;
using System.Linq;

namespace Maganizer_Project.BLL.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IUnitOfWork DataBase { get; set; }
        
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
            
            if(userProfile == null)
            {
                return null;
            }

            return new UserProfileDTO()
            {
                Username = userProfile.ApplicationUser.UserName,
                About = userProfile.About,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                EmailForContacts = userProfile.EmailForContacts,
                WebSiteUrl = userProfile.WebSiteUrl,
                Country = userProfile.Country,
                City = userProfile.City,
                Street = userProfile.Street,
                Avatar = userProfile.Avatar
            };

        }
        public void UpdateProfile(EditUserProfileDTO editProfileDTO)
        {
            var account = DataBase.Accounts.GetByName(editProfileDTO.Username);

            byte[] newAvatar;

            if (editProfileDTO.NewAvatar != null)
            {
                newAvatar = ImageConvertion.ConvertToByteArray(editProfileDTO.NewAvatar);
            }
            else
            {
                newAvatar = null;
            }

            var profileId = DataBase.UserProfiles.GetByAccountId(account.Result.Id).Id;

            UserProfile userProfile = new UserProfile()
            {
                Id = profileId,
                FirstName = editProfileDTO.FirstName,
                LastName = editProfileDTO.LastName,
                Country = editProfileDTO.Country,
                City = editProfileDTO.City,
                Street = editProfileDTO.Street,
                About = editProfileDTO.About,
                WebSiteUrl = editProfileDTO.WebSiteUrl,
                EmailForContacts = editProfileDTO.EmailForContacts,
                Avatar = newAvatar,
                ApplicationUserId = account.Result.Id
            };

            DataBase.UserProfiles.Update(userProfile);
            DataBase.Save();

        }

    }
}
