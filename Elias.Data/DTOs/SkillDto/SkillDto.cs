using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.SkillDto
{
    public class SkillGroupDto
    {
        [Display(Name = "گروه مهارت")]
        [MaxLength(100)]
        public string SkillGroupName { get; set; }

        public int Id { get; set; }
    }

    public class SkillDto
    {
        public int Id { get; set; }

        
        public int SkillGroupId { get; set; }

        [Display(Name = " گروه مهارت")]
        [MaxLength(150)]
        public string SkillGroupName { get; set; }

        [Display(Name ="مهارت")]
        [MaxLength(150)]
        public string SkillName { get; set; }

        [Display(Name = "درصد مهارت")]
        [MaxLength(10)]
        public int SkillValue { get; set; }
    }
}
