using Elias.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Permission
{
    public class RolePermission : BaseEntity<int>
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }

        #region Navigation Property
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }

        [ForeignKey(nameof(PermissionId))]
        public Permission Permission { get; set; }
        #endregion
    }
}
