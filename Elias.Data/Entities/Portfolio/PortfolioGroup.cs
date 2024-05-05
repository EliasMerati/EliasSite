using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Portfolio
{
    public class PortfolioGroup : BaseEntity<int>
    {
        [Display(Name = "گروه پرتفولیو")]
        [MaxLength(150)]
        public string GroupName { get; set; }

        #region Navigation Property
        public ICollection<Portfolio> Portfolios { get; set; }
        #endregion
    }
}
