using Elias.Application.Interfaces;
using Elias.Application.Services;
using Elias.Common;
using Elias.Data.Entities.Comment;
using Elias.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Elias.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioService _portfolioService;
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;

        public HomeController(ILogger<HomeController> logger, IPortfolioService portfolioService, IBlogService blogService, ICommentService commentService)
        {
            _logger = logger;
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

        public IActionResult Privacy()
        {
            return View();
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

        [Route("/CreateComment")]
        public IActionResult CreateComment()
        { return View("_ContactMeText"); }

        [HttpPost]
        [Route("/CreateComment")]
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
            _commentService.CreateComment(newcomment);
            return View();
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