using Microsoft.AspNetCore.Identity;

namespace Maganizer_Project.DAL.Entities
{
    public class UserAccount
    {    
        public IdentityUser IdentityUser { get; set; }
        public string Password { get; set; }
    }
}
