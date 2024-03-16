using Elias.Data.DTOs.PortfolioDto;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Application.Interfaces
{
    public interface IPortfolioGroupService
    {
        Task<PortfolioGroup> FindPortfolioGroupById(int id);
        List<PortfolioGroupDto> GetPortfolioGroupList();
        Task UpdatePortfolioGroup(PortfolioGroup group);
        Task CreatePortfolioGroup(PortfolioGroup group);
        Task DeletePortfolioGroup(PortfolioGroup group);
        bool IsPortfolioGroupExist();
        IList<SelectListItem> GetPortfolioGroup();
    }
}
