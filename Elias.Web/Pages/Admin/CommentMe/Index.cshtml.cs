using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.Entities.Comment;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.CommentMe
{
    [PermissionChecker(42)]
    public class IndexModel : PageModel
    {
        #region Inject service
        private readonly ICommentService _commentService;
        public IndexModel(ICommentService commentService)
        {
            _commentService = commentService;
        }
        #endregion

        public List<Comment> Comments { get; set; }
        public void OnGet()
        {
            Comments = _commentService.GetCommentList();
        }
    }
}
