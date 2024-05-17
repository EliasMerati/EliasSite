using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Admin.Pages.Portfolio
{
    [PermissionChecker(32)]
    public class UpdatePortfolioModel : PageModel
    {
        #region Inject Services
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioGroupService _portfolioGroupService;

        public UpdatePortfolioModel(IPortfolioService portfolioService, IPortfolioGroupService portfolioGroupService)
        {
            _portfolioService = portfolioService;
            _portfolioGroupService = portfolioGroupService;
        }
        #endregion

        [BindProperty]
        public Elias.Data.Entities.Portfolio.Portfolio portfolio { get; set; }
        public void OnGet(int Id)
        {
            var groups = _portfolioGroupService.GetPortfolioGroup();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            portfolio = _portfolioService.FindPortfolioById(Id);
        }

        public async Task<IActionResult> OnPost(IFormFile Image)
        {
            try
            {
                await _portfolioService.UpdatePortfolio(portfolio, Image);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
