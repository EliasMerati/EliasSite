using Elias.Application.Attribute;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages
{
    [PermissionChecker(1)]
    public class IndexModel : PageModel
    {

    }
}
