using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateAsync(UserAccount item)
        {
            var result = await userManager.CreateAsync(item.IdentityUser, item.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(string Username, string Password, bool RememberMe)
        {
            var result = await signInManager.PasswordSignInAsync(Username, Password, RememberMe, false);        
            return result;
        }

        public async Task SignOutAsync()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<ApplicationUser> GetByName(string username)
        {
            return await userManager.FindByNameAsync(username);
        }

        //public void Delete(Guid id)
        //{
        //    UserAccount item = db.Accounts.Find(id);
        //    if(item != null)
        //    {
        //        db.Accounts.Remove(item);
        //    }
        //}

        //public IEnumerable<UserAccount> Find(Func<UserAccount, bool> predicate)
        //{
        //    return db.Accounts.Where(predicate).ToList();
        //}

        //public UserAccount Get(Guid id)
        //{
        //    return db.Accounts.Find(id);
        //}

        //public IEnumerable<UserAccount> GetAll()
        //{
        //    return db.Accounts;
        //}

        //public void Update(UserAccount item)
        //{
        //    db.Entry(item).State = EntityState.Modified;
        //}
    }
}
