using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Admin.Pages.Blog
{
    [PermissionChecker(39)]
    public class CreateBlogModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        private readonly IBlogService _blogService;
        public CreateBlogModel(IBlogGroupService blogGroupService, IBlogService blogService)
        {
            _blogService = blogService;
            _blogGroupService = blogGroupService;
        }
        #endregion

        [BindProperty]
        public Elias.Data.Entities.Blog.Blog Blog { get; set; }
        public void OnGet()
        {
            var groups = _blogGroupService.GetBlogGroup();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
        }

        public async Task<IActionResult> OnPost(IFormFile Image)
        {
            try
            {
                Blog.CreateDate = DateTime.Now;
                await _blogService.CreateBlog(Blog, Image);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
           
        }
    }
}
