using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Experience
{
    public class Experience : BaseEntity<int>
    {
        [Display(Name = "موضوع تجربه")]
        [MaxLength(50)]
        public string ExperienceSubject { get; set; }

        [Display(Name = "تاریخ")]
        [MaxLength(50)]
        public string ExperienceDate { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}
