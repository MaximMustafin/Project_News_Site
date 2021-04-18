using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private MaganizerContext db;
        public CommentRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(Comment item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> Find(Func<Comment, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
