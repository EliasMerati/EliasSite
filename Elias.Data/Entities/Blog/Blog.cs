using Elias.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Entities.Blog
{
    public class Blog : BaseEntity<int>
    {
        public int BlogGroup { get; set; }
        public string BlogSubject { get; set; }
        public string Author { get; set; }
        public string BlogShortDescription { get; set; }
        public string BlogDescription { get; set; }
        public string BlogImage { get; set; }

        #region Navigation Properties
        public ICollection<BlogComment> BlogComments { get; set; }

        [ForeignKey(nameof(BlogGroup))]
        public BlogGroup Group { get; set; }
        #endregion

    }
}
