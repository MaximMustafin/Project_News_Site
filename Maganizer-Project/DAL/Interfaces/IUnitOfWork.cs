using Maganizer_Project.DAL.Entities;
using System;

namespace Maganizer_Project.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserAccount> Accounts { get; }
        IRepository<UserProfile> Profiles { get; }
        IRepository<Post> Posts { get; }
        IRepository<Tag> Tags { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Category> Categories { get; }
        void Save();
    }
}
