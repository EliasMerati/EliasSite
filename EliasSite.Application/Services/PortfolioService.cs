using Elias.Application.Interfaces;
using Elias.Data.Context;

namespace Elias.Application.Services
{
    public class PortfolioService : IPortfolioService
    {
        #region Inject Database
        private readonly DatabaseContext _db;

        public PortfolioService(DatabaseContext db)
        {
            _db = db;
        }

        #endregion
    }
}
