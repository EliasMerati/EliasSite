using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.PortfolioGroup
{
    public class RemovePortfolioGroupModel : PageModel
    {
        private readonly IPortfolioGroupService _portfolioGroupService;
        public RemovePortfolioGroupModel(IPortfolioGroupService portfolioGroupService)
        {
            _portfolioGroupService = portfolioGroupService;
        }

        [BindProperty]
        public Elias.Data.Entities.Portfolio.PortfolioGroup Group { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            Group = await _portfolioGroupService.FindPortfolioGroupById(Id);
            if (Group is null)
            {
                return NotFound();
            }
            await _portfolioGroupService.DeletePortfolioGroup(Group);
            return RedirectToPage("Index");
        }
    }
}
