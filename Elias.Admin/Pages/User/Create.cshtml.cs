using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
#nullable disable
    public class CreateModel : PageModel
    {
        #region Injection
        private readonly IUserService _userService;
        public CreateModel(IUserService userService)
        {
            _userService = userService;    
        }
        #endregion

        [BindProperty]
        public CreateUserDto user { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile Image, IFormFile Resumeh)
        {
            await _userService.CreateUserAsync(user, Image, Resumeh);
            return RedirectToPage("/Index");
        }
    }
}
