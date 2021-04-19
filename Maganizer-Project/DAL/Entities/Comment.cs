using System;

namespace Maganizer_Project.DAL.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Author Id
        /// </summary>
        public Guid UserAccountId { get; set; }
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }

    }
}
