using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.Models
{
    public class PostViewModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public DateTime PostedOn { get; set; }
        public byte[] FeaturedImage { get; set; }
        public string NextPost { get; set; }
        public string PrevPost { get; set; }
    }
}
