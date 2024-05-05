using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Education
{
    public class Education : BaseEntity<int>
    {
        [Display(Name = "مقطع تحصیلی")]
        [MaxLength(50)]
        public string EducationCertificate { get; set; }

        [Display(Name = "از - تا ")]
        [MaxLength(150)]
        public string Since { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }
    }
}
