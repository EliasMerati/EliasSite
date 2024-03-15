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
}
