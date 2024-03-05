using Elias.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Data.Entities.Skills
{
    public class Skill : BaseEntity<int>
    {
        public int SkillGroupId { get; set; }
        public string SkillName { get; set; }
        public int SkillValue { get; set; }

        #region Navigation Property
        public SkillGroup SkillGroup { get; set; }
        #endregion
    }
}
