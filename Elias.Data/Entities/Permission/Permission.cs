using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Permission
{
    public class Permission : BaseEntity<int>
    {

        [Display(Name = "نام قسمت")]
        [MaxLength(150)]
        public string PermissionTitle { get; set; }
        public int? ParentId { get; set; }

        #region Navigation Property
        [ForeignKey(nameof(ParentId))]
        public ICollection<Permission> Permissions { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
        #endregion
    }
}
