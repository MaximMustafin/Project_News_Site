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
        public async Task<IdentityResult> CreateUserAsync(SignUpUserDTO signUpUser)
        {
            IdentityUser identityUser = new IdentityUser()
            {
                UserName = signUpUser.NewUsername,
                Email = signUpUser.Email
            };

            UserAccount user = new UserAccount()
            {
                IdentityUser = identityUser,
                Password = signUpUser.NewPassword
            };

            return await DataBase.Accounts.Create(user);         
        }
    }
}
