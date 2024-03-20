using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.Blog
{
    public class BlogGroupDto
    {
        public int Id { get; set; }

        [Display(Name = "گروه بلاگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100)]
        public string BlogGroupName { get; set; }
    }

    public class BlogDto
    {
        public int Id { get; set; }

        [Display(Name = "گروه بلاگ")]
        public int BlogGroup { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(200)]
        public string BlogSubject { get; set; }

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100)]
        public string Author { get; set; }

        [Display(Name = "توضیح مختصر")]
        public string BlogShortDescription { get; set; }

        [Display(Name = "توضیحات")]
        public string BlogDescription { get; set; }

        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(100)]
        public string BlogImage { get; set; }
    }
}
