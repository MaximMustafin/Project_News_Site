using Maganizer_Project.BLL.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Maganizer_Project.WEB.Models
{
    public class EditUserProfileViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        [StringLength(45, ErrorMessage = "Max length - 45")]
        public string FirstName { get; set; }
        [StringLength(45, ErrorMessage = "Max length - 45")]
        public string LastName { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(2048)]
        public string WebSiteUrl { get; set; }

        [StringLength(45, ErrorMessage = "Max length - 45")]
        public string Country { get; set; }

        [StringLength(45, ErrorMessage = "Max length - 45")]
        public string City { get; set; }

        [StringLength(45, ErrorMessage = "Max length - 45")]
        public string Street { get; set; }

        [StringLength(150, ErrorMessage = "Max length - 150")]
        public string About { get; set; }

        [MaxFileSize(1 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile NewAvatar { get; set; }

        public byte[] OldAvatar { get; set; }
    }
}
