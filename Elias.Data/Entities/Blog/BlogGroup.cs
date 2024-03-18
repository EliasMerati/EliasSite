using Elias.Data.Common;

namespace Elias.Data.Entities.Blog
{
    public class BlogGroup : BaseEntity<int>
    {
        public string BlogGroupName { get; set; }

        #region Navigation Properties
        public ICollection<Blog> Blogs { get; set; }
        #endregion
    }
}
