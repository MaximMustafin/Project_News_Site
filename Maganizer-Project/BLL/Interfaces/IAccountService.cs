using Maganizer_Project.BLL.DTO;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.Interfaces
{
    public interface IAccountService
    {
        Task<SignUpResultDTO> CreateUser(SignUpUserDTO signUpUser);
        Task<SignInResult> SignInAsync(SignInUserDTO signInUser);
        Task SignOutAsync();
        Task<IdentityResult> ConfirmEmail(string userId, string code);
    }
}
