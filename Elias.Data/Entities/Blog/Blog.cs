using Elias.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Blog
{
    public class Blog : BaseEntity<int>
    {
        [Display(Name = "گروه بلاگ")]
        [MaxLength(50)]
        public int BlogGroup { get; set; }

        [Display(Name = "موضوع بلاگ")]
        [MaxLength(150)]
        public string BlogSubject { get; set; }

        [Display(Name = "نویسنده")]
        [MaxLength(50)]
        public string Author { get; set; }

        [Display(Name = "توضیحات مختصر")]
        public string BlogShortDescription { get; set; }

        [Display(Name = "توضیحات")]
        public string BlogDescription { get; set; }

        [Display(Name = "عکس بلاگ")]
        [MaxLength(150)]
        public string BlogImage { get; set; }

        #region Navigation Properties
        public ICollection<BlogComment> BlogComments { get; set; }

        [ForeignKey(nameof(BlogGroup))]
        public BlogGroup Group { get; set; }
        #endregion

    }
}
