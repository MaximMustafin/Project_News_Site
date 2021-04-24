using Microsoft.AspNetCore.Identity;

namespace Maganizer_Project.DAL.Entities
{
    public class AspNetUsersExtension: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string About { get; set; }
        public string WebSiteUrl { get; set; }
        public byte[] Avatar { get; set; }

    }
}
