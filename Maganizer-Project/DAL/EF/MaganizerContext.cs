using Maganizer_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maganizer_Project.DAL.EF
{
    public class MaganizerContext: DbContext
    {
        public DbSet<UserAccount> Accounts { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public MaganizerContext(DbContextOptions<MaganizerContext> options)
            : base(options)
        {
        }
    }
}
