using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Portfolio
{
    public class PortfolioImages : BaseEntity<int>
    {
        public int PortfolioId { get; set; }

        [MaxLength(150)]
        public string PortfolioImageName { get; set; }

        #region Navigation Property

        [ForeignKey(nameof(PortfolioId))]
        public Portfolio Portfolio { get; set; }
        #endregion
    }
}
