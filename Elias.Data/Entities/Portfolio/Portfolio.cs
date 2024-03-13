using Elias.Data.Common;

namespace Elias.Data.Entities.Portfolio
{
    public class Portfolio : BaseEntity<int>
    {
        public int GroupId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioFamily { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public string PortfolioDate { get; set; }
        public string MainPicure { get; set; }
        public string? PortfolioLink { get; set; }

        #region Navigation Property
        public ICollection<PortfolioImages> PortfolioImages { get; set; }
        public PortfolioGroup PortfolioGroup { get; set; }
        #endregion
    }
}
