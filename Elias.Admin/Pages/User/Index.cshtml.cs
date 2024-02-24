using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    public class IndexModel : PageModel
    {
        #region Injection
        private readonly IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }
        #endregion
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

    }
}
