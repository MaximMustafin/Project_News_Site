using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> Find(Func<Post, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Post Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Post item)
        {
            throw new NotImplementedException();
        }
    }
}
