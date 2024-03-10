using Elias.Application.Interfaces;
using Elias.Data.Context;

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
    }
}
