using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Admin.Pages.Portfolio
{
    [PermissionChecker(30)]
    public class CreatePortfolioModel : PageModel
    {
        #region Inject Services
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioGroupService _portfolioGroupService;

        public CreatePortfolioModel(IPortfolioService portfolioService, IPortfolioGroupService portfolioGroupService)
        {
            _portfolioService = portfolioService;
            _portfolioGroupService = portfolioGroupService;
        }
        #endregion

        [BindProperty]
        public Elias.Data.Entities.Portfolio.Portfolio portfolio { get; set; }
        public void OnGet()
        {
            var groups = _portfolioGroupService.GetPortfolioGroup();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
        }

        public async Task<IActionResult> OnPost(IFormFile Image, List<IFormFile> Images)
        {
            await _portfolioService.CreatePortfolio(portfolio, Image, Images);
            return RedirectToPage("Index");
        }
    }
}
