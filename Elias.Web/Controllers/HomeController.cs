using Elias.Application.Interfaces;
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
            var portfolio = _portfolioService.FindPortfolioById(Id);
            return View("_ProjectSingle",portfolio);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}