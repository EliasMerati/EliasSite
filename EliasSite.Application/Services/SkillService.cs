using Elias.Application.Interfaces;
using Elias.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
