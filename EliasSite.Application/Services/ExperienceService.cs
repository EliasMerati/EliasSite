using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs;
using Elias.Data.Entities.Experience;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Application.Services
{
    public class ExperienceService : IExperienceService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public ExperienceService(DatabaseContext db)
        {
            _db = db;   
        }
        #endregion


        public async Task CreateExperience(Experience experience)
        {
            _db.Add(experience);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteExperience(Experience experience)
        {
            _db.Remove(experience);
            await _db.SaveChangesAsync();
        }

        public async Task<Experience> FindExperienceById(int id)
        {
            return await _db.Experiences.FindAsync(id);
        }

        public List<ExperienceDto> GetExperienceList()
        {
            return _db.Experiences
                .Select(x => new ExperienceDto()
                {
                    Id = x.Id,
                    Description = x.Description,
                    ExperienceDate = x.ExperienceDate,
                    ExperienceSubject = x.ExperienceSubject,
                }).AsNoTracking().ToList();
        }

        public bool IsEexperienceExist()
        {
            return _db.Experiences.Any();
        }

        public async Task UpdateExperience(Experience experience)
        {
            _db.Update(experience);
            await _db.SaveChangesAsync();
        }
    }
}
