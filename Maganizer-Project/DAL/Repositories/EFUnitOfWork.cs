using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public void Save()
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        public IRepository<UserAccount> Accounts => throw new NotImplementedException();

        public IRepository<UserProfile> Profiles => throw new NotImplementedException();

        public IRepository<Post> Posts => throw new NotImplementedException();

        public IRepository<Tag> Tags => throw new NotImplementedException();

        public IRepository<Comment> Comments => throw new NotImplementedException();

        public IRepository<Category> Categories => throw new NotImplementedException();

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
