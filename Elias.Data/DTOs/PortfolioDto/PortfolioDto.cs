using System.ComponentModel.DataAnnotations;

namespace Elias.Data.DTOs.PortfolioDto
{
    public class PortfolioGroupDto
    {
        public int Id { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string GroupName { get; set; }
    }

    public class PortfolioDto
    {
        public int Id { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public int GroupId { get; set; }

        [Display(Name = "نام نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioName { get; set; }

        [Display(Name = "خانواده ی نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioFamily { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "نام کارفرما")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string CustomerName { get; set; }

        [Display(Name = "تاریخ انجام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioDate { get; set; }

        [Display(Name = "عکس نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string MainPicure { get; set; }

        [Display(Name = "آدرس سایت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string? PortfolioLink { get; set; }

        [Display(Name = "سایر عکس های نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(300)]
        public List<string> Images { get; set; }
    }

    public class GetPortfolioForIndex
    {
        public int Id { get; set; }

        [Display(Name = "نام نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioName { get; set; }

        [Display(Name = "خانواده ی نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioFamily { get; set; }

        [Display(Name = "نام کارفرما")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string CustomerName { get; set; }

        [Display(Name = "تاریخ انجام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string PortfolioDate { get; set; }
    }

   public class GetPortfolioForShowByGroupIdDto
    {
        public int Id { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(50)]
        public string GroupName { get; set; }

        [Display(Name = "عکس نمونه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string MainPicure { get; set; }
    }
}
