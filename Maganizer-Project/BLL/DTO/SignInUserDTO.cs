using System.ComponentModel.DataAnnotations;

namespace Maganizer_Project.BLL.DTO
{
    public class SignInUserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }     
    }
}
