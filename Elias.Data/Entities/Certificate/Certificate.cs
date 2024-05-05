using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Certificate
{
    public class Certificate : BaseEntity<int>
    {
        [Display(Name = "نام مدرک")]
        [MaxLength(150)]
        public string CertificateName { get; set; }

        [Display(Name = "تاریخ اخذ مدرک")]
        [MaxLength(150)]
        public string CertificateDate { get; set; }

        [Display(Name = "سریال مدرک")]
        [MaxLength(150)]
        public string CertificateID { get; set; }

        [Display(Name = "عکس مدرک")]
        [MaxLength(150)]
        public string? CertificateImage { get; set; }
    }
}
