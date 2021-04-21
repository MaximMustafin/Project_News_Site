using System.ComponentModel.DataAnnotations;

namespace Maganizer_Project.BLL.DTO
{
    public class SignUpUserDTO
    {
        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Fullname")]
        public string Fullname { get; set; }

        [Required(ErrorMessage ="Please enter your username")]
        [Display(Name = "Username")]
        public string NewUsername { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a strong password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
