using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class ProfileRepository : IRepository<UserProfile>
    {
        private MaganizerContext db;
        public ProfileRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(UserProfile item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserProfile> Find(Func<UserProfile, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public UserProfile Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UserProfile item)
        {
            throw new NotImplementedException();
        }
    }
}
