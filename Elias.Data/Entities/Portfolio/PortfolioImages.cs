using Elias.Data.Common;

namespace Elias.Data.Entities.Portfolio
{
    public class PortfolioImages : BaseEntity<int>
    {
        public int PortfolioId { get; set; }
        public List<string> Images { get; set; }

        #region Navigation Property
        public Portfolio Portfolio { get; set; }
        #endregion
    }
}
