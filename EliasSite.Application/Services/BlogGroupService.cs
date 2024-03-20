using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs.Blog;
using Elias.Data.Entities.Blog;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class BlogGroupService : IBlogGroupService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public BlogGroupService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion


        public async Task CreateBlogGroup(BlogGroup blogGroup)
        {
            _db.Add(blogGroup);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteBlogGroup(BlogGroup blogGroup)
        {
            _db.Remove(blogGroup);
            await _db.SaveChangesAsync();
        }

        public async Task<BlogGroup> FindBlogGroupById(int id)
        {
            return await _db.BlogGroups.FindAsync(id);
        }

        public List<BlogGroupDto> GetBlogGroupList()
        {
            return _db.BlogGroups
                .Select(bg => new BlogGroupDto
                {
                    Id = bg.Id,
                    BlogGroupName = bg.BlogGroupName
                }).AsNoTracking().ToList();  
        }

        public IList<SelectListItem> GetBlogGroup()
        {
            return _db.BlogGroups.Select(l => new SelectListItem()
            {
                Value = l.Id.ToString(),
                Text = l.BlogGroupName
            }).AsNoTracking().ToList();
        }

        public bool IsBlogGroupExist()
        {
            return _db.BlogGroups.Any();
        }

        public async Task UpdateBlogGroup(BlogGroup blogGroup)
        {
            _db.Update(blogGroup);
            await _db.SaveChangesAsync();
        }

    }
}
