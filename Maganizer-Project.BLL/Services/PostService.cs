using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Entities;
using Maganizer_Project.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maganizer_Project.BLL.Services
{
    public class PostService : IPostService
    {
        private IUnitOfWork DataBase { get; set; }
        public PostService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }
        public void AddPost(PostDTO postDTO)
        {
            var tags = postDTO.Tags.Split().Distinct();

            Post post = new Post()
            {
                Name = postDTO.Name,
                Content = postDTO.Content,
                DateOfCreation = DateTime.Now,
                Tags = new List<Tag>(tags.Count())
            };

            foreach(var x in tags)
            {
                Tag tag = new Tag()
                {
                    Name = x
                };

                post.Tags.Add(tag);
            }

            DataBase.Posts.Create(post);
            DataBase.Save();
        }
    }
}
