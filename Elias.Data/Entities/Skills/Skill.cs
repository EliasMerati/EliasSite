using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Skills
{
    public class Skill : BaseEntity<int>
    {
        public int SkillGroupId { get; set; }

        [Display(Name = "نام مهارت")]
        [MaxLength(150)]
        public string SkillName { get; set; }

        [Display(Name = "درصد مهارت")]
        [MaxLength(50)]
        public string SkillValue { get; set; }

        #region Navigation Property
        public SkillGroup SkillGroup { get; set; }
        #endregion
    }
}
