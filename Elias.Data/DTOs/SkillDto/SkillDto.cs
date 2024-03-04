using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.SkillDto
{
    public class SkillGroupDto
    {
        [Display(Name = "گروه مهارت")]
        [MaxLength(100)]
        public string SkillGroupName { get; set; }
    }
}
