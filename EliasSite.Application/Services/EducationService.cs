using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs;
using Elias.Data.Entities.Education;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class EducationService : IEducationService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public EducationService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion


        public async Task CreateEducation(Education education)
        {
            _db.Add(education);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteEducation(Education education)
        {
            _db.Remove(education);
            await _db.SaveChangesAsync();
        }

        public async Task<Education> FindEducationById(int Id)
        {
            return await _db.Educations.FindAsync(Id);
        }

        public List<EducationDto> GetEducationList()
        {
            return _db.Educations
                .Select(d => new EducationDto()
                {
                    Description = d.Description,
                    EducationCertificate = d.EducationCertificate,
                    Since = d.Since,
                }).AsNoTracking().ToList();
        }

        public bool IsEducationExist()
        {
            return _db.Educations.Any();
        }

        public async Task UpdateEducation(Education education)
        {
            _db.Update(education);
            await _db.SaveChangesAsync();
        }
    }
}
