using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs.SkillDto;
using Elias.Data.Entities.Skills;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class SkillService : ISkillService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public SkillService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

        public async Task CreateSkill(SkillDto skill)
        {
            await _db.AddAsync(skill);
            await _db.SaveChangesAsync();
        }

        public async Task<Skill> FindSkillById(int id)
        {
            return await _db.Skills.FindAsync(id);
        }

        public List<SkillDto> GetSkillList()
        {
            return _db.Skills
                .Include(s=>s.SkillGroup)
                .Select(s => new SkillDto
                {
                    Id = s.Id,
                    SkillName = s.SkillName,
                    SkillGroupName = s.SkillGroup.SkillGroupName,
                    SkillGroupId = s.SkillGroupId,
                    SkillValue = s.SkillValue,
                }).AsNoTracking().ToList();
        }

        public List<SkillDto> GetSkillListBySkillGroup(int SkillGroupId)
        {
            return _db.Skills
                .Include(s => s.SkillGroup)
                .Where(s => s.SkillGroupId == SkillGroupId)
                .Select(s => new SkillDto
                {
                    Id = s.Id,
                    SkillName = s.SkillName,
                    SkillGroupId = s.SkillGroupId,
                    SkillValue = s.SkillValue,
                }).AsNoTracking().ToList();
        }

        public bool IsSkillExist()
        {
            return _db.Skills.Any();
        }

        public async Task UpdateSkill(Skill skill)
        {
            _db.Update(skill);
            await _db.SaveChangesAsync();
        }
    }
}
