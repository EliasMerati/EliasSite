using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages
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

        public List<UserDto> users { get; set; }
        public async Task<IActionResult> OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                users = await _userService.GetUserForAdminAsync();
                return Page();
            }
            return RedirectToPage("Login");
        }
    }
}