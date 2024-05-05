using Elias.Data.Common;
using Elias.Data.Entities.Permission;

namespace Elias.Data.Entities
{
    public class Role : BaseEntity<int>
    {
        public string RoleTitle { get; set; }


        #region Navigation Property
        public ICollection<User> Users { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
        #endregion
    }
}
