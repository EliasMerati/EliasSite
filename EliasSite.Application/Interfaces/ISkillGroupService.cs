using Elias.Data.DTOs.SkillDto;
using Elias.Data.Entities.Skills;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Application.Interfaces
{
    public interface ISkillGroupService
    {
        List<SkillGroupDto> GetAllSkillGroup();
        List<SelectListItem> GetSkillGroup();
        Task AddSkillGroup(SkillGroupDto skillGroup);
        Task UpdateSkillGroup(SkillGroup skillGroup);
        Task<SkillGroup> FindById(int id);
        bool IsSkillGroupExist();
    }
}
