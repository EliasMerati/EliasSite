﻿using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Entities.Comment;
using Elias.Web.Models;
using Ganss.Xss;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Elias.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;

        public HomeController( IPortfolioService portfolioService, IBlogService blogService, ICommentService commentService)
        {
            _portfolioService = portfolioService;
            _blogService = blogService;
            _commentService = commentService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("/DarkIndex")]
        public IActionResult DarkIndex()
        {
            return View("DarkIndex");
        }

        [Route("/ProjectSingle/{Id}")]
        public IActionResult ProjectSingle(int Id)
        {
            var portfolio = _portfolioService.GetEntirePortfoWithImagesAndGroupsById(Id);
            return View("_ProjectSingle", portfolio);
        }

        [Route("/BlogSingle/{Id}")]
        public IActionResult BlogSingle(int Id)
        {
            var Blog = _blogService.GetEntireBlog(Id);
            return View("_BlogSingle", Blog);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View("_ContactMeText", comment);
            }
            var newcomment = new Comment()
            {
                Company = comment.Company,
                CreateDate = DateTime.Now,
                Email = comment.Email,
                Name = comment.Name,
                Subject = comment.Subject,
                Text = comment.Text,
            };
            #region Sanitize Comment
            var sanitizer = new HtmlSanitizer();
            var result = sanitizer.Sanitize(newcomment.Text);
            var result2 = sanitizer.Sanitize(newcomment.Email);
            var result3 = sanitizer.Sanitize(newcomment.Name);
            var result4 = sanitizer.Sanitize(newcomment.Subject);
            var result5 = sanitizer.Sanitize(newcomment.Company);
            newcomment.Text = result;
            newcomment.Email = result2;
            newcomment.Name = result3;
            newcomment.Subject = result4;
            newcomment.Text = result5;
            #endregion
            _commentService.CreateComment(newcomment);
            return LocalRedirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = GenerateCode.GenerateUniqueCode() + Path.GetExtension(upload.FileName).ToLower();

            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/CKEditorsImage/",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }

            var url = $"{"/CKEditorsImage/"}{fileName}";

            return Json(new { uploaded = true, url });
        }
    }
}