using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;

namespace Maganizer_Project.BLL.Services
{
    public class UserProfileService : IUserProfileService
    {
        IUnitOfWork DataBase { get; set; }
        
        public UserProfileService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }
        public void UpdateProfile(EditProfileDTO profileDTO)
        {
            AspNetUsersExtension newProfileInfo = new AspNetUsersExtension()
            {
                FullName = profileDTO.FullName,
                Country = profileDTO.Country,
                City = profileDTO.City,
                Street = profileDTO.Street,
                About = profileDTO.About,
                WebSiteUrl = profileDTO.WebSiteUrl,
                Avatar = profileDTO.Avatar
            };

            DataBase.Accounts.UpdateAsync(newProfileInfo);
        }

        //TODO
        //GetProfile()
    }
}
