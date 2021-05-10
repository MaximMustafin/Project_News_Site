using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.Models
{
    public class AdminPostEditorViewModel
    {
        [Required(ErrorMessage = "Please enter post's name")]
        [StringLength(100)]
        public string PostName { get; set; }

        [Required(ErrorMessage = "You can not post empty news")]
        public string PostContent { get; set; }

        [Required(ErrorMessage = "Please enter at least one tag")]
        [StringLength(100)]
        public string Tags { get; set; }
        public bool SuccessPost { get; set; }
    }
}
