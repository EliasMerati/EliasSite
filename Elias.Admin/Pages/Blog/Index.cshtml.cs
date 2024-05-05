using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.Blog;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Blog
{
    [PermissionChecker(37)]
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IBlogService _blogService;
        public IndexModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        #endregion

        public Tuple< List<BlogDto>,int> Blogs { get; set; }
        public void OnGet()
        {
            Blogs = _blogService.GetBlogList();
        }
    }
}
