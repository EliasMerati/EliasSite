﻿using Elias.Data.DTOs.Blog;
using Elias.Data.Entities.Blog;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Application.Interfaces
{
    public interface IBlogGroupService
    {
        Task<BlogGroup> FindBlogGroupById(int id);
        List<BlogGroupDto> GetBlogGroupList();
        Task UpdateBlogGroup(BlogGroup blogGroup);
        Task CreateBlogGroup(BlogGroup blogGroup);
        Task DeleteBlogGroup(BlogGroup blogGroup);
        bool IsBlogGroupExist();
        IList<SelectListItem> GetBlogGroup();
    }
}
