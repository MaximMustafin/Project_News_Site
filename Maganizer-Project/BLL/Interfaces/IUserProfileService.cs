using Maganizer_Project.BLL.DTO;

namespace Maganizer_Project.BLL.Interfaces
{
    public interface IUserProfileService
    {
        void UpdateProfile(EditProfileDTO profileDTO);
    }
}
