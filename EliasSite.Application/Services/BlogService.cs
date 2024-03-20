﻿using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Context;
using Elias.Data.DTOs.Blog;
using Elias.Data.Entities.Blog;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Application.Services
{
    public class BlogService : IBlogService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public BlogService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion


        public async Task CreateBlog(Blog blog, IFormFile Image)
        {
            await SetBlogPic(blog, Image);
            _db.Add(blog);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteBlog(Blog blog)
        {
            await DeleteBlogPic(blog);
            _db.Remove(blog);
            await _db.SaveChangesAsync();
        }

        public async Task<Blog> FindBlogById(int id)
        {
            return await _db.Blogs.FindAsync(id);
        }

        public List<BlogDto> GetBlogList()
        {
            return _db.Blogs
                     .Include(b => b.BlogGroup)
                     .Select(b => new BlogDto()
                     {
                         Id = b.Id,
                         Author = b.Author,
                         BlogDescription = b.BlogDescription,
                         BlogImage = b.BlogImage,
                         BlogShortDescription = b.BlogShortDescription,
                         BlogSubject = b.BlogSubject,
                         BlogGroupId = b.Group.Id,
                         BlogGroupName = b.Group.BlogGroupName,
                     }).AsNoTracking()
                     .ToList();
        }

        public bool IsBlogExist()
        {
            return _db.Blogs.Any();
        }

        public async Task UpdateBlog(Blog blog, IFormFile Image)
        {
            await SetBlogPic(blog, Image);
            _db.Update(blog);
            await _db.SaveChangesAsync();
        }

        private async Task SetBlogPic(Blog blog, IFormFile Image)
        {
            if (Image is not null)
            {
                if (blog.BlogImage is null)
                {
                    blog.BlogImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/BlogImage/", blog.BlogImage);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
                else
                {
                    string DeleteDemoPath = "";
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/BlogImage/", blog.BlogImage);
                    if (File.Exists(DeleteDemoPath))
                    {
                        File.Delete(DeleteDemoPath);
                    }

                    blog.BlogImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/BlogImage/", blog.BlogImage);
                    using (var stream = new FileStream(DeleteDemoPath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
            }
        }
        private async Task DeleteBlogPic(Blog blog)
        {
            string DeleteDemoPath = "";
            DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/BlogImage/", blog.BlogImage);
            if (File.Exists(DeleteDemoPath))
            {
                File.Delete(DeleteDemoPath);
            }
        }
    }
}