using System;
using System.Collections.Generic;

namespace Maganizer_Project.DAL.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Author Id
        /// </summary>
        public Guid UserAccountId { get; set; }
        public Guid CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
