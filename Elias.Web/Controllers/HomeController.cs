using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Elias.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioService _portfolioService;

        public HomeController(ILogger<HomeController> logger,IPortfolioService portfolioService)
        {
            _logger = logger;
            _portfolioService = portfolioService;
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
            return View("_ProjectSingle",portfolio);
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
                Directory.GetCurrentDirectory(), "wwwroot/CKEditorsImage",
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