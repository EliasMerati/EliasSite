using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    public class IndexModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

    }
}
