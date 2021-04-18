using Maganizer_Project.DAL.EF;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private MaganizerContext db;
        public TagRepository(MaganizerContext context)
        {
            this.db = context;
        }
        public void Create(Tag item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> Find(Func<Tag, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Tag Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Tag item)
        {
            throw new NotImplementedException();
        }
    }
}
