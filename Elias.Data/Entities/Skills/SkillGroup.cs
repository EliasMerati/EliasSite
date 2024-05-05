using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Skills
{
    public class SkillGroup : BaseEntity<int>
    {
        [Display(Name = "گروه مهارت")]
        [MaxLength(150)]
        public string SkillGroupName { get; set; }

        #region Navigation Property
        public ICollection<Skill> Skills { get; set; }
        #endregion
    }
}
