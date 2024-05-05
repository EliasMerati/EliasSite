using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.PortfolioDto;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.PortfolioGroup
{
    [PermissionChecker(25)]
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IPortfolioGroupService _portfolioGroup;

        public IndexModel(IPortfolioGroupService portfolioGroup)
        {
            _portfolioGroup = portfolioGroup;
        }
        #endregion

        public List<PortfolioGroupDto> group { get; set; }
        public void OnGet()
        {
            group = _portfolioGroup.GetPortfolioGroupList();
        }
    }
}
