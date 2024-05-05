using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Entities.Blog
{
    public class BlogGroup : BaseEntity<int>
    {
        [Display(Name = "گروه بلاگ")]
        [MaxLength(150)]
        public string BlogGroupName { get; set; }

        #region Navigation Properties
        public ICollection<Blog> Blogs { get; set; }
        #endregion
    }
}
