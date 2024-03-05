using Elias.Data.DTOs.SkillDto;
using Elias.Data.Entities.Skills;

namespace Elias.Application.Interfaces
{
    public interface ISkillGroupService
    {
        List<SkillGroupDto> GetAllSkillGroup();
        Task AddSkillGroup(SkillGroupDto skillGroup);
        Task UpdateSkillGroup(SkillGroup skillGroup);
        Task<SkillGroup> FindById(int id);
        bool IsSkillGroupExist();
    }
}
