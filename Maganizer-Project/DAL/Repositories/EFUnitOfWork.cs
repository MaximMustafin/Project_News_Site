using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Maganizer_Project.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private MaganizerContext db;
        //private AccountRepository accountRepository;
        //private ProfileRepository profileRepository;
        private PostRepository postRepository;
        private TagRepository tagRepository;
        private CommentRepository commentRepository;
        private CategoryRepository categoryRepository;

        public EFUnitOfWork(MaganizerContext db)
        {
            this.db = db;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        //public IRepository<UserAccount> Accounts
        //{
        //    get
        //    {
        //        if(accountRepository == null)
        //        {
        //            accountRepository = new AccountRepository(db);
        //        }
        //        return accountRepository;
        //    }
        //}

        //public IRepository<UserProfile> Profiles
        //{
        //    get
        //    {
        //        if (profileRepository == null)
        //        {
        //            profileRepository = new ProfileRepository(db);
        //        }
        //        return profileRepository;
        //    }
        //}

        public IRepository<Post> Posts
        {
            get
            {
                if (postRepository == null)
                {
                    postRepository = new PostRepository(db);
                }
                return postRepository;
            }
        }

        public IRepository<Tag> Tags
        {
            get
            {
                if (tagRepository == null)
                {
                    tagRepository = new TagRepository(db);
                }
                return tagRepository;
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                if (commentRepository == null)
                {
                    commentRepository = new CommentRepository(db);
                }
                return commentRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(db);
                }
                return categoryRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
