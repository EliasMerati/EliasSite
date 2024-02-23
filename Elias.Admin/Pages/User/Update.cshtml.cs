using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public UpdateUserDto user { get; set; }
        public async Task<IActionResult> OnGet( int Id)
        {
            return Page();
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
