using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
    [PermissionChecker(4)]
    public class ChangePasswordModel : PageModel
    {
        #region Injection
        private readonly IUserService _userService;
        public ChangePasswordModel(IUserService userService)
        {
            _userService = userService;    
        }
        #endregion

        [BindProperty]
        public ChangePasswordDto Change { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                var username = User.Identity.Name;
                if (!ModelState.IsValid)
                    return Page();

                if (await _userService.CompareOldPassword(Change.OldPassword, username) is not true)
                {
                    ModelState.AddModelError("OldPassword", "کلمه ی عبور فعلی صحیح نمیباشد");
                }

                _userService.ChangeNewPassword(username, Change.Password);
                return RedirectToPage("/LogOut");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
           
        }
    }
}
