using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Portfolio
{
    public class Portfolio : BaseEntity<int>
    {
        public int GroupId { get; set; }

        [Display(Name = "نام پرتفولیو")]
        [MaxLength(150)]
        public string PortfolioName { get; set; }

        [Display(Name = "گروه پرتفولیو")]
        [MaxLength(150)]
        public string PortfolioFamily { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "کارفرما")]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [Display(Name = "تاریخ انجام")]
        [MaxLength(150)]
        public string PortfolioDate { get; set; }

        [Display(Name = "عکس اصلی")]
        [MaxLength(150)]
        public string MainPicure { get; set; }

        [Display(Name = "لینک سایت")]
        [MaxLength(150)]
        public string? PortfolioLink { get; set; }

        #region Navigation Property
        public ICollection<PortfolioImages> PortfolioImages { get; set; }

        [ForeignKey(nameof(GroupId))]
        public PortfolioGroup PortfolioGroup { get; set; }
        #endregion
    }
}
