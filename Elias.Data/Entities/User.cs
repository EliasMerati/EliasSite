using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities
{
#nullable disable
    public class User : BaseEntity<int>
    {
        public int RoleId { get; set; }

        [Display(Name = "نام")]
        [MaxLength(60)]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(60)]
        public string Familly { get; set; }

        [Display(Name = "نام کاربری")]
        [MaxLength(150)]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [MaxLength(150)]
        public string Password { get; set; }

        [Display(Name = "عکس")]
        [MaxLength(150)]
        public string UserImage { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "شماره تماس")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Display(Name = "تاریخ تولد")]
        [MaxLength(100)]
        public string BirthDay { get; set; }

        [Display(Name = "استان")]
        [MaxLength(50)]
        public string Ostan { get; set; }

        [Display(Name = "شهر")]
        [MaxLength(50)]
        public string City { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات")]
        public string MainDescription { get; set; }

        [Display(Name = "رزومه")]
        [MaxLength(150)]
        public string Resumeh { get; set; }

        [Display(Name = "تخصص اصلی")]
        [MaxLength(100)]
        public string MainSkill { get; set; }

        [Display(Name = "تخصص ها")]
        public string Skills { get; set; }

        [Display(Name = "گیت هاب")]
        [MaxLength(100)]
        public string GitHub { get; set; }

        [Display(Name = "لینکدین")]
        [MaxLength(100)]
        public string LinkedIn { get; set; }

        [Display(Name = "اسکایپ")]
        [MaxLength(100)]
        public string Skype { get; set; }

        [Display(Name = "فعال / غیر فعال")]
        public bool IsActive { get; set; }


        #region Navigation Property
        [ForeignKey(nameof(RoleId))]
        public ICollection<Role> Roles { get; set; }
        #endregion
    }
}
