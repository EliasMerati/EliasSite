using Elias.Application.Interfaces;
using Elias.Data.Context;

namespace Elias.Application.Services
{
    public class PermissionService : IPermissionService
    {
        #region Inject DB
        private readonly DatabaseContext _db;
        public PermissionService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _db.Users.Single(u=> u.UserName == userName).Id;

            List<int> UserRole = _db.Users
                .Where(u => u.Id == userId)
                .Select(r => r.RoleId)
                .ToList();

            if (!UserRole.Any())
                return false;

            List<int> RolesPermission = _db.RolePermissions
                .Where(u => u.PermissionId == permissionId)
                .Select(r => r.RoleId)
                .ToList();

            return RolesPermission.Any(p=>UserRole.Contains(p));
        }
    }
}
