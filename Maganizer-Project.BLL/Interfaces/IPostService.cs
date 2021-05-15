using Maganizer_Project.BLL.DTO;

namespace Maganizer_Project.BLL.Interfaces
{
    public interface IPostService
    {
        void AddPost(EditPostDTO postDTO);
        GetPostDTO GetPostByName(string name);
    }
}
