using Elias.Application.Interfaces;
using Elias.Data.Context;

namespace Elias.Application.Services
{
    public class BlogCommentService : IBlogCommentService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public BlogCommentService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion
    }
}
