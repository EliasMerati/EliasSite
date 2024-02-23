using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public CreateUserDto user { get; set; }
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
