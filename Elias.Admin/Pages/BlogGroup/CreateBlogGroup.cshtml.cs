using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Application.Services;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.BlogGroup
{
    [PermissionChecker(34)]
    public class CreateBlogGroupModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        public CreateBlogGroupModel(IBlogGroupService blogGroupService)
        {
            _blogGroupService = blogGroupService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Blog.BlogGroup BlogGroup { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _blogGroupService.CreateBlogGroup(BlogGroup);
            return RedirectToPage("Index");
        }
    }
}
