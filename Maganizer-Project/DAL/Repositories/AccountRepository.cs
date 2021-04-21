using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class AccountRepository: IAccountRepository
    {

        private UserManager<IdentityUser> db;
        public AccountRepository(UserManager<IdentityUser> context)
        {
            this.db = context;
        }

        public async Task<IdentityResult> Create(UserAccount item)
        {
            var result = await db.CreateAsync(item.IdentityUser, item.Password);
            return result;
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
