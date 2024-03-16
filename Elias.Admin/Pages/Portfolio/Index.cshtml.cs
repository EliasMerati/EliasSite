using Elias.Application.Interfaces;
using Elias.Data.DTOs.PortfolioDto;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Portfolio
{
    public class IndexModel : PageModel
    {
        #region Inject Services
        private readonly IPortfolioService _portfolioService;

        public IndexModel(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        #endregion

        public List<GetPortfolioForIndex> portfolios { get; set; }
        public void OnGet()
        {
            portfolios = _portfolioService.GetPortfolioList();
        }
    }
}
