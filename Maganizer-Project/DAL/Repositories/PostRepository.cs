using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maganizer_Project.DAL.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private MaganizerContext db;

        public PostRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(Post item)
        {
            db.Posts.Add(item);
        }

        public void Delete(Guid id)
        {
            Post item = db.Posts.Find(id);
            if (item != null)
            {
                db.Posts.Remove(item);
            }
        }

        public IEnumerable<Post> Find(Func<Post, bool> predicate)
        {
            return db.Posts.Where(predicate).ToList();
        }

        public Post Get(Guid id)
        {
            return db.Posts.Find(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        public void Update(Post item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
