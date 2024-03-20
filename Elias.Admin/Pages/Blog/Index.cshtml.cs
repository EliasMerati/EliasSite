using Elias.Application.Interfaces;
using Elias.Data.DTOs.Blog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Blog
{
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IBlogService _blogService;
        public IndexModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        #endregion

        public List<BlogDto> Blogs { get; set; }
        public void OnGet()
        {
            Blogs = _blogService.GetBlogList();
        }
    }
}
