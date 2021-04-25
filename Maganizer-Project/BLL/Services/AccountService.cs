using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork DataBase { get; set; }

        public AccountService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }

        public async Task<IdentityResult> CreateUser(SignUpUserDTO signUpDTO)
        {
            AspNetUsersExtension identityUser = new AspNetUsersExtension()
            {
                UserName = signUpDTO.Username,
                Email = signUpDTO.Email
            };

            UserAccount user = new UserAccount()
            {
                IdentityUser = identityUser,
                Password = signUpDTO.Password
            };

            return await DataBase.Accounts.CreateAsync(user);         
        }

        public async Task<SignInResult> SignInAsync(SignInUserDTO signInDTO)
        {
            return await DataBase.Accounts.PasswordSignInAsync(signInDTO.Username, signInDTO.Password, signInDTO.RememberMe);
        }

        public async Task SignOutAsync()
        {
            await DataBase.Accounts.SignOutAsync();
        }
    }
}
