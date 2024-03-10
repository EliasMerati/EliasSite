using Elias.Application.Interfaces;
using Elias.Data.Context;
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
    }
}
