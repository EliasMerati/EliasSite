using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.BlogGroup
{
    public class DeleteBlogGroupModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        public DeleteBlogGroupModel(IBlogGroupService blogGroupService)
        {
            _blogGroupService = blogGroupService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Blog.BlogGroup BlogGroup
        {
            get; set;
        }


        public async Task<IActionResult> OnGet(int Id)
        {
            BlogGroup =await _blogGroupService.FindBlogGroupById(Id);
            if (BlogGroup is null)
            {
                return NotFound();
            }
            await _blogGroupService.DeleteBlogGroup(BlogGroup);
            return RedirectToPage("Index");
        }
    }
}
