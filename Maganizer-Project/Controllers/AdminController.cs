using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IPostService postService;

        public AdminController(IWebHostEnvironment hostingEnvironment, IPostService postService)
        {
            _hostingEnvironment = hostingEnvironment;
            this.postService = postService;
        }

        [Route("Admin/PostEditor")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("PostEditor");
        }

        [Route("Admin/PostEditor")]
        [HttpPost]
        public IActionResult MakePost(AdminPostEditorViewModel editorViewModel)
        {
            if (ModelState.IsValid)
            {
                SaveNewImage(new List<IFormFile>() { editorViewModel.FeaturedImage });
                EditPostDTO postDTO = new EditPostDTO()
                {
                    Name = editorViewModel.PostName,
                    Content = editorViewModel.PostContent,
                    Tags = editorViewModel.Tags,
                    FeaturedImage = editorViewModel.FeaturedImage
                };             

                postService.AddPost(postDTO);

                editorViewModel.SuccessPost = true;
            }
            return View("PostEditor", editorViewModel);
        }

        [HttpPost("UploadFiles")]
        [Produces("application/json")]
        public async Task<IActionResult> SaveNewImage(List<IFormFile> file)
        {
            if(file == null)
            {
                var ex = new ArgumentException();
                return Json(ex.Message);
            }

            IFormFile theFile = file[0];

            // Get the server path, wwwroot
            string webRootPath = _hostingEnvironment.WebRootPath;

            // Building the path to the uploads directory
            var fileRoute = Path.Combine(webRootPath, "uploads");

            // Get File Extension
            string extension = System.IO.Path.GetExtension(theFile.FileName);

            // Generate Random name.
            string name = Guid.NewGuid().ToString().Substring(0, 8) + extension;

            // Build the full path inclunding the file name
            string link = Path.Combine(fileRoute, name);

            // Basic validation on mime types and file extension
            string[] imageExt = { ".gif", ".jpeg", ".jpg", ".png", ".svg", ".blob" };

            try
            {
                if ((Array.IndexOf(imageExt, extension) >= 0))
                {
                    // Copy contents to memory stream.
                    Stream stream;
                    stream = new MemoryStream();
                    theFile.CopyTo(stream);
                    stream.Position = 0;
                    String serverPath = link;

                    // Save the file
                    using (FileStream writerFileStream = System.IO.File.Create(serverPath))
                    {
                        await stream.CopyToAsync(writerFileStream);
                        writerFileStream.Dispose();
                    }

                    // Return the file path as json
                    Hashtable imageUrl = new Hashtable
                    {
                        { "link", "/uploads/" + name }
                    };

                    return Json(imageUrl);
                }
                throw new ArgumentException("The image did not pass the validation");
            }

            catch (ArgumentException ex)
            {
                return Json(ex.Message);
            }
        }


    }
}
