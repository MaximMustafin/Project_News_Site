using Maganizer_Project.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.WEB.Models
{
    public class SignInUpViewModel
    {   
        public SignInUserDTO SignInUser { get; set; }
        public SignUpUserDTO SignUpUser { get; set; }
    }
}
