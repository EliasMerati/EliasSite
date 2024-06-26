﻿using Elias.Data.DTOs.Blog;
using Elias.Data.Entities.Blog;
using Microsoft.AspNetCore.Http;

namespace Elias.Application.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> FindBlogById(int id);
        public Tuple<List<BlogDto>, int> GetBlogList(int pageId = 1);
        Task UpdateBlog(Blog blog, IFormFile Image);
        Task CreateBlog(Blog blog, IFormFile Image);
        Task DeleteBlog(Blog blog);
        Blog GetEntireBlog(int id);
        bool IsBlogExist();
    }
}
