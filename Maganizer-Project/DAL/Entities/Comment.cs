using System;

namespace Maganizer_Project.DAL.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public UserAccount UserAccount { get; set; }
        public Post Post { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
