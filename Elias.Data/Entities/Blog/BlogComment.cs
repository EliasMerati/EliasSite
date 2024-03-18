using Elias.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias.Data.Entities.Blog
{
    public class BlogComment : BaseEntity<int>
    {
        public int CommentId { get; set; }
        public string AuthorName { get; set; }
        public string CommentText { get; set; }

        #region Navigation Properties
        [ForeignKey(nameof(CommentId))]
        public Blog Blog { get; set; }
        #endregion
    }
}
