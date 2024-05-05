using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.BlogGroup
{
    [PermissionChecker(35)]
    public class UpdateBlogGroupModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        public UpdateBlogGroupModel(IBlogGroupService blogGroupService)
        {
            _blogGroupService = blogGroupService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Blog.BlogGroup BlogGroup { get; set; }
        public async void OnGet(int Id)
        {
            BlogGroup = await _blogGroupService.FindBlogGroupById(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            await _blogGroupService.UpdateBlogGroup(BlogGroup);
            return RedirectToPage("Index");
        }
    }
}
