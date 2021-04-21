using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.BLL.DTO
{
    public class SignInUserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}
