using Elias.Application.Interfaces;
using Elias.Data.Context;

namespace Elias.Application.Services
{
    public class PortfolioGroupService : IPortfolioGroupService
    {
        #region Inject Database
        private readonly DatabaseContext _db;

        public PortfolioGroupService(DatabaseContext db)
        {
            _db = db;
        }

        #endregion
    }
}
