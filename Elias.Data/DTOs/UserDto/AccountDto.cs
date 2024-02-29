using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.UserDto
{
    #region Login

    public enum LoginResult
    {
        Success, Erorr, UserNotFound
    }

    public class LoginDto
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(250)]
        [EmailAddress(ErrorMessage = "لطفا فرمت ایمیل معتبر وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "کلمه ی عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }

    public class ChangePasswordDto
    {
        [Display(Name = "کلمه عبور فعلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Display(Name = "کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "  تکرار کلمه عبور جدید ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }

    #endregion
}
