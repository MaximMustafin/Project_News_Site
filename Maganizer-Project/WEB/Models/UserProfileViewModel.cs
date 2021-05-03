namespace Maganizer_Project.WEB.Models
{
    public class UserProfileViewModel
    {
        public int Id { get;set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteUrl { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string About { get; set; }
        public string FullName { get; set; }
        public byte[] Avatar { get; set; }
    }
}
