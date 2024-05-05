using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.PortfolioGroup
{
    [PermissionChecker(27)]
    public class UpdatePortfolioGroupModel : PageModel
    {
        private readonly IPortfolioGroupService _portfolioGroupService;
        public UpdatePortfolioGroupModel(IPortfolioGroupService portfolioGroupService)
        {
            _portfolioGroupService = portfolioGroupService;
        }

        [BindProperty]
        public Elias.Data.Entities.Portfolio.PortfolioGroup Group { get; set; }
        public async void OnGet(int Id)
        {
            Group = await _portfolioGroupService.FindPortfolioGroupById(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            await _portfolioGroupService.UpdatePortfolioGroup(Group);
            return RedirectToPage("Index");
        }
    }
}
