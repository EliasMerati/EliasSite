using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    [PermissionChecker(5)]
    [BindProperties]
    public class UpdateModel : PageModel
    {
        #region Injection
        private readonly IUserService _userService;
        public UpdateModel(IUserService userService)
        {
            _userService = userService;
        }
        #endregion


        public Elias.Data.Entities.User user { get; set; }

        public async Task<IActionResult> OnGet(int Id)
        {
            user = await _userService.FindUserForUpdateAsync(Id);
            if (user == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPost(IFormFile Image, IFormFile Resumeh)
        {

            await _userService.UpdateUser(user, Image, Resumeh);
            return RedirectToPage("/Index");
        }
    }
}
