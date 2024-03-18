using Elias.Application.Interfaces;
using Elias.Data.Context;

namespace Elias.Application.Services
{
    public class BlogGroupService : IBlogGroupService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public BlogGroupService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

    }
}
