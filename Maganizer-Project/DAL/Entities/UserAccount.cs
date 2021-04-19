using System;

namespace Maganizer_Project.DAL.Entities
{
    public class UserAccount
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
