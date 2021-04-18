using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> Find(Func<UserAccount, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public UserAccount Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserAccount item)
        {
            throw new NotImplementedException();
        }
    }
}
