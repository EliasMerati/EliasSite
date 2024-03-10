using Elias.Data.DTOs;
using Elias.Data.Entities.Education;

namespace Elias.Application.Interfaces
{
    public interface IEducationService
    {
        Task<Education> FindEducationById(int id);
        List<EducationDto> GetEducationList();
        Task UpdateEducation(Education education);
        Task CreateEducation(Education education);
        Task DeleteEducation(Education education);
        bool IsEducationExist();
    }
}
