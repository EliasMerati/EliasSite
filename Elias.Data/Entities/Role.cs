using Elias.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Data.Entities
{
    public class Role : BaseEntity<int>
    {
        public string RoleTitle { get; set; }


        #region Navigation Property
        public ICollection<User> Users { get; set; }
        #endregion
    }
}
