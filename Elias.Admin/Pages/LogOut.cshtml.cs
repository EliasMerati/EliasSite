using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages
{
    public class LogOutModel : PageModel
    {
        public async Task<IActionResult>  OnGet()
        {
            await HttpContext.SignOutAsync();
            return RedirectToPage("Index");
        }
    }
}
