using Elias.Data.DTOs.PortfolioDto;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Http;

namespace Elias.Application.Interfaces
{
    public interface IPortfolioService
    {
        Portfolio FindPortfolioById(int id);
        Portfolio GetEntirePortfoWithImagesAndGroupsById(int id);
        List<GetPortfolioForIndex> GetPortfolioList();
        List<GetPortfolioForShowByGroupIdDto> GetPortfolio();
        Task UpdatePortfolio(Portfolio portfolio, IFormFile Image);
        Task CreatePortfolio(Portfolio portfolio, IFormFile Image, List<IFormFile> images);
        int GetPortfolioForPortfolioId(Portfolio portfolio);
        Task DeletePortfolio(Portfolio portfolio);
        bool IsPortfolioExist();

    }
}
