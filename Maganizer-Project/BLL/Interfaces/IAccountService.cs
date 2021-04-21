using Maganizer_Project.BLL.DTO;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserDTO signUpUser);
    }
}
