using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maganizer_Project.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.Controllers
{
    public class TagArchiveController : Controller
    {
        private readonly ITagService tagService;
        public TagArchiveController(ITagService tagService)
        {
            this.tagService = tagService;
        }

        [HttpGet("Tag")]
        public IActionResult GetTag(string name)
        {
            return View("TagsArchive");
        }
    }
}
