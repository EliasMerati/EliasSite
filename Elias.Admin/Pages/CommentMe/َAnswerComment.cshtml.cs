using Elias.Application.Interfaces;
using Elias.Data.Entities.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.CommentMe
{
    public class _َAnswerCommentModel : PageModel
    {
        #region Inject Service
        private readonly ICommentService _commentService;
        public _َAnswerCommentModel(ICommentService commentService)
        {
            _commentService = commentService;
        }
        #endregion

        [BindProperty]
        public Comment comment { get; set; }
        public async void OnGet(int Id)
        {
            comment = await _commentService.FindCommentById(Id);
        }

        public async Task<IActionResult> OnPost(string answere)
        {
            _commentService.AnswerQuestion(answere, comment.Email);
            return RedirectToPage("Index");
        }
    }
}
