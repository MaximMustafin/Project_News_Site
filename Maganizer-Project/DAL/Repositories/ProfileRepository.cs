using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            db.Profiles.Add(item);
        }

        public void Delete(Guid id)
        {
            UserProfile item = db.Profiles.Find(id);
            if (item != null)
            {
                db.Profiles.Remove(item);
            }
        }

        public IEnumerable<UserProfile> Find(Func<UserProfile, bool> predicate)
        {
            return db.Profiles.Where(predicate).ToList();
        }

        public UserProfile Get(Guid id)
        {
            return db.Profiles.Find(id);
        }

        public IEnumerable<UserProfile> GetAll()
        {
            return db.Profiles;
        }

        public void Update(UserProfile item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
