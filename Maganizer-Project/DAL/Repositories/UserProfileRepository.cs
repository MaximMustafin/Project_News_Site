using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maganizer_Project.DAL.Repositories
{
    public class UserProfileRepository : IProfileRepository
    {
        private MaganizerContext db;
        public UserProfileRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(UserProfile item)
        {
            db.UserProfiles.Add(item);
        }

        public UserProfile Get(int? id)
        {
            return db.UserProfiles.Find(id);
        }

        public IEnumerable<UserProfile> GetAll()
        {
            return db.UserProfiles;
        }

        public void Update(UserProfile item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
