using Maganizer_Project.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> Create(UserAccount item);
    }
}
