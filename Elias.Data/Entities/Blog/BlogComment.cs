using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Blog
{
    public class BlogComment : BaseEntity<int>
    {
        public int BlogId { get; set; }

        [Display(Name = "نام شخص")]
        [MaxLength(150)]
        public string AuthorName { get; set; }

        [Display(Name = "متن نظر")]
        [MaxLength(150)]
        public string CommentText { get; set; }

        #region Navigation Properties
        [ForeignKey(nameof(BlogId))]
        public Blog Blog { get; set; }
        #endregion
    }
}
