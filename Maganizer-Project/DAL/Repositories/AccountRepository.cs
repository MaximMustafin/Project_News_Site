using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maganizer_Project.DAL.Repositories
{
    public class AccountRepository : IRepository<UserAccount>
    {
        private MaganizerContext db;
        public AccountRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(UserAccount item)
        {
            db.Accounts.Add(item);
        }

        public void Delete(Guid id)
        {
            UserAccount item = db.Accounts.Find(id);
            if(item != null)
            {
                db.Accounts.Remove(item);
            }
        }

        public IEnumerable<UserAccount> Find(Func<UserAccount, bool> predicate)
        {
            return db.Accounts.Where(predicate).ToList();
        }

        public UserAccount Get(Guid id)
        {
            return db.Accounts.Find(id);
        }

        public IEnumerable<UserAccount> GetAll()
        {
            return db.Accounts;
        }

        public void Update(UserAccount item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
