using System;
using System.Collections.Generic;

namespace Maganizer_Project.DAL.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public UserAccount UserAccount { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
