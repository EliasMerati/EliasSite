using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages
{
    public class LoginModel : PageModel
    {
        #region Injection

        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        [BindProperty]
        public LoginDto Login { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            #region Validation
            if (!ModelState.IsValid)
            {
                return Page();
            }
            #endregion

            return Page();
        }
    }
}
