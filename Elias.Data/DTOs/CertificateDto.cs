using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs
{
    public class CertificateDto
    {
        public int Id { get; set; }

        [Display(Name = "نام مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string CertificateName { get; set; }

        [Display(Name = "تاریخ مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string CertificateDate { get; set; }

        [Display(Name = "سریال مدرک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string CertificateID { get; set; }

        [Display(Name = "عکس مدرک")]
        public IFormFile CertificateImage { get; set; }
    }
}
