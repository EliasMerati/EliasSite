using Elias.Data.DTOs.Blog;
using Elias.Data.Entities.Blog;

namespace Elias.Application.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> FindBlogById(int id);
        List<BlogDto> GetBlogList();
        Task UpdateBlog(Blog blog);
        Task CreateBlog(Blog blog);
        Task DeleteBlog(Blog blog);
        bool IsBlogExist();
    }
}
