using Elias.Data.Common;

namespace Elias.Data.Entities.Portfolio
{
    public class PortfolioGroup : BaseEntity<int>
    {
        public string GroupName { get; set; }

        #region Navigation Property
        public ICollection<Portfolio> Portfolios { get; set; }
        #endregion
    }
}
