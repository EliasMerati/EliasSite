using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.BlogGroup
{
    [PermissionChecker(33)]
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IBlogGroupService _blogGroupService;
        public IndexModel(IBlogGroupService blogGroupService)
        {
            _blogGroupService = blogGroupService;
        }
        #endregion

        public List<Elias.Data.DTOs.Blog.BlogGroupDto> BlogGroups { get; set; }
        public void OnGet()
        {
            BlogGroups = _blogGroupService.GetBlogGroupList();
        }
    }
}
