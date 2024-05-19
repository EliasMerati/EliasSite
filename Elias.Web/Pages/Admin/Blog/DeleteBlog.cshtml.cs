using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Blog
{
    [PermissionChecker(41)]
    public class DeleteBlogModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        private readonly IBlogService _blogService;
        public DeleteBlogModel(IBlogGroupService blogGroupService, IBlogService blogService)
        {
            _blogService = blogService;
            _blogGroupService = blogGroupService;
        }
        #endregion

        [BindProperty]
        public Elias.Data.Entities.Blog.Blog Blog { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            try
            {
                Blog = await _blogService.FindBlogById(Id);
                if (Blog is null)
                {
                    return NotFound();
                }
                await _blogService.DeleteBlog(Blog);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
           
        }
    }
}
