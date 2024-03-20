using Elias.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Blog
{
    public class BlogComment : BaseEntity<int>
    {
        public int BlogId { get; set; }
        public string AuthorName { get; set; }
        public string CommentText { get; set; }

        #region Navigation Properties
        [ForeignKey(nameof(BlogId))]
        public Blog Blog { get; set; }
        #endregion
    }
}
