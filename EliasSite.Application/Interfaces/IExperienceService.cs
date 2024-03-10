using Elias.Data.DTOs;
using Elias.Data.Entities.Experience;

namespace Elias.Application.Interfaces
{
    public interface IExperienceService
    {
        Task<Experience> FindExperienceById(int id);
        List<ExperienceDto> GetExperienceList();
        Task UpdateExperience(Experience experience);
        Task CreateExperience(Experience experience);
        Task DeleteExperience(Experience experience);
        bool IsEexperienceExist();
    }
}
