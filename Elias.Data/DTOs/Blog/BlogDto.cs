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
}
