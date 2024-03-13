using Elias.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Elias.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [Route("/ProjectSingle")]
        public IActionResult ProjectSingle()
        {
            return View("_ProjectSingle");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}