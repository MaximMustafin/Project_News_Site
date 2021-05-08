using Maganizer_Project.BLL.DTO;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.DAL.Interfaces;
using Maganizer_Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Maganizer_Project.BLL.Services
{
    public class TagService : ITagService
    {
        IUnitOfWork DataBase { get; set; }

        public TagService(IUnitOfWork unitOfWork)
        {
            DataBase = unitOfWork;
        }

        public IEnumerable<TagDTO> GetTags()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Tag, TagDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Tag>, List<TagDTO>>(DataBase.Tags.GetAll());
        }
    }
}
