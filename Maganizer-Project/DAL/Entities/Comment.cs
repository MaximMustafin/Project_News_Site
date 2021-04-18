using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
