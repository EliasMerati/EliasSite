using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs.SkillDto;
using Elias.Data.Entities.Skills;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Application.Services
{
    public class SkillGroupService : ISkillGroupService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public SkillGroupService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

        public async Task AddSkillGroup(SkillGroupDto skillGroup)
        {
            var skillgroup = new SkillGroup()
            {
                CreateDate = DateTime.Now,
                SkillGroupName = skillGroup.SkillGroupName,
            };
            _db.Add(skillgroup);
            await _db.SaveChangesAsync();
        }

        public async Task<SkillGroup> FindById(int id)
        {
            return await _db.SkillGroups.FindAsync(id);
        }

        public List<SkillGroupDto> GetAllSkillGroup()
        {
            return _db.SkillGroups.Select(sg => new SkillGroupDto()
            {
                SkillGroupName = sg.SkillGroupName,
                Id = sg.Id,
            }).AsNoTracking().ToList();
        }

        public bool IsSkillGroupExist()
        {
            return  _db.SkillGroups.Any();
        }

        public async Task RemoveSkillGroup(int id)
        {
            var skillgroup = FindById(id);
            _db.Remove(skillgroup);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateSkillGroup(SkillGroup skillGroup)
        {
            skillGroup.CreateDate = DateTime.Now;
            _db.Update(skillGroup);
            await _db.SaveChangesAsync();
        }
    }
}
