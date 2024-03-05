using Elias.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Data.Entities.Skills
{
    public class SkillGroup : BaseEntity<int>
    {
        public string SkillGroupName { get; set; }

        #region Navigation Property
        public ICollection<Skill> Skills { get; set; }
        #endregion
    }
}
