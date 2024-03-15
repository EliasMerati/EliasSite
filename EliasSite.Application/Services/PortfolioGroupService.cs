using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs.PortfolioDto;
using Elias.Data.Entities.Portfolio;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class PortfolioGroupService : IPortfolioGroupService
    {
        #region Inject Database
        private readonly DatabaseContext _db;

        public PortfolioGroupService(DatabaseContext db)
        {
            _db = db;
        }

        #endregion


        public async Task CreatePortfolioGroup(PortfolioGroup group)
        {
            _db.Add(group);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePortfolioGroup(PortfolioGroup group)
        {
            _db.Remove(group);
            await _db.SaveChangesAsync();
        }

        public async Task<PortfolioGroup> FindPortfolioGroupById(int id)
        {
            return await _db.PortfolioGroups.FindAsync(id);
        }

        public List<PortfolioGroupDto> GetPortfolioGroupList()
        {
            return _db.PortfolioGroups
                .Select(p => new PortfolioGroupDto()
                {
                    GroupName = p.GroupName,
                    Id = p.Id,
                }).AsNoTracking()
                .ToList();
        }

        public bool IsPortfolioGroupExist()
        {
            return _db.PortfolioGroups.Any();
        }

        public async Task UpdatePortfolioGroup(PortfolioGroup group)
        {
            _db.Update(group);
            await _db.SaveChangesAsync();
        }
    }
}
