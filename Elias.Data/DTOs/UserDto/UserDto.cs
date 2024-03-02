using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Elias.Data.DTOs.UserDto
{
    #region UserDto
    public class UserDto
    {
        public int Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Familly { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string UserName { get; set; }

        [Display(Name = "مهارت اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string MainSkill { get; set; }

        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PhoneNumber { get; set; }
    }
  
    #endregion

    #region Create User DTO
    public enum CreateUserResult
    { Success, Error }

    public class CreateUserDto
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Familly { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string UserName { get; set; }

        [Display(Name = "کلمه ی عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Password { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(250)]
        public string Email { get; set; }

        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PhoneNumber { get; set; }

        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string BirthDay { get; set; }

        [Display(Name = "استان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string Ostan { get; set; }

        [Display(Name = "شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string City { get; set; }

        [Display(Name = "رزومه")]
        public IFormFile Resumeh { get; set; }

        [Display(Name = "عکس")]
        public IFormFile UserImage { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        public string Address { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(250)]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        public string MainDescription { get; set; }

        [Display(Name = "مهارت اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string MainSkill { get; set; }

        [Display(Name = "مهارت ها")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(300)]
        public string Skills { get; set; }

        [Display(Name = "گیت هاب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string GitHub { get; set; }

        [Display(Name = "لینکداین")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string LinkedIn { get; set; }

        [Display(Name = "اسکایپ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Skype { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; } = true;
    }
    #endregion




}
