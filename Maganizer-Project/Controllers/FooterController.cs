using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.Extensions;
using Maganizer_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.WEB.Controllers
{
    public class FooterController : Controller
    {
        private readonly ITagService tagService;
        public FooterController(ITagService tagService)
        {
            this.tagService = tagService;
        }

        [HttpGet("Footer/GetTags")]
        public ActionResult GetTags()
        {
            if (HttpRequestExtensions.IsAjaxRequest(Request))
            {
                IEnumerable<TagDTO> tags = tagService.GetTags();
                var tagsViewModel = new TagsViewModel()
                {
                    Tags = tags.ToList()
                };
                return PartialView("_TagsInfo", tagsViewModel);
            }

            return View("ErrorNotFound");

        }
    }
}
