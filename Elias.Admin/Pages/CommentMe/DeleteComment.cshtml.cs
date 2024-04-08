using Elias.Application.Interfaces;
using Elias.Data.Entities.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.CommentMe
{
    public class DeleteCommentModel : PageModel
    {
        #region Inject Service
        private readonly ICommentService _commentService;
        public DeleteCommentModel(ICommentService commentService)
        {
            _commentService = commentService;
        }
        #endregion
        [BindProperty]
        public Comment Comment { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            Comment = await _commentService.FindCommentById(Id);
            await _commentService.DeleteComment(Comment);
            return RedirectToPage("Index");
        }
    }
}
