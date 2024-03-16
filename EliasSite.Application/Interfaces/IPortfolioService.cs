using Elias.Data.DTOs.PortfolioDto;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Application.Interfaces
{
    public interface IPortfolioService
    {
        Portfolio FindPortfolioById(int id);
        List<GetPortfolioForIndex> GetPortfolioList();
        List< GetPortfolioForShowByGroupIdDto> GetPortfolio();
        Task UpdatePortfolio(Portfolio portfolio);
        Task CreatePortfolio(Portfolio portfolio, IFormFile Image, List<IFormFile> images);
        int CreatePortfolioForPortfolioId(Portfolio portfolio);
        Task DeletePortfolio(Portfolio portfolio);
        bool IsPortfolioExist();
        
    }
}
