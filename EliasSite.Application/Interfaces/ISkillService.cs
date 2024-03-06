using Elias.Data.DTOs.SkillDto;
using Elias.Data.Entities.Skills;

namespace Elias.Application.Interfaces
{
    public interface ISkillService
    {
        Task<Skill> FindSkillById(int id);
        List<SkillDto> GetSkillList();
        List<SkillDto> GetSkillListBySkillGroup(int SkillGroupId);
        Task UpdateSkill(Skill skill);
        Task CreateSkill(Skill skill);
        bool IsSkillExist();
    }
}
