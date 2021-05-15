using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("Post")]
        public IActionResult GetPost(string name)
        {
            var post = postService.GetPostByName(name);

            if(post == null)
            {
                return View("ErrorNotFound");
            }

            PostViewModel postViewModel = new PostViewModel()
            {
                Name = post.Name,
                Content = post.Content,
                PostedOn = post.DateOfCreation,
                FeaturedImage = post.FeaturedImage,
                NextPost = post.NextPostName,
                PrevPost = post.PreviousPostName
            };

            postViewModel.Tags = new List<string>(post.Tags.Count());

            foreach (var x in post.Tags)
            {
                postViewModel.Tags.Add(x.Name);
            }
            return View("Post", postViewModel);
        }
    }
}
