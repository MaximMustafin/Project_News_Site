using System;

namespace Maganizer_Project.DAL.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
