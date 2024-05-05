using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Portfolio
{
    [PermissionChecker(32)]
    public class DeletePortfolioModel : PageModel
    {
        private readonly IPortfolioService _portfolioService;
        public DeletePortfolioModel(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [BindProperty]
        public Elias.Data.Entities.Portfolio.Portfolio Portfolio { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            Portfolio =  _portfolioService.FindPortfolioById(Id);
            if (Portfolio is null)
            {
                return NotFound();
            }
            await _portfolioService.DeletePortfolio(Portfolio);
            return RedirectToPage("Index");
        }
    }
}
