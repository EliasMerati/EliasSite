using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.PortfolioGroup
{
    [PermissionChecker(27)]
    public class CreatePortfolioGroupModel : PageModel
    {
        private readonly IPortfolioGroupService _portfolioGroupService;
        public CreatePortfolioGroupModel(IPortfolioGroupService portfolioGroupService)
        {
            _portfolioGroupService = portfolioGroupService;
        }

        [BindProperty]
        public Elias.Data.Entities.Portfolio.PortfolioGroup Group { get; set; }
        public async void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                await _portfolioGroupService.CreatePortfolioGroup(Group);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
