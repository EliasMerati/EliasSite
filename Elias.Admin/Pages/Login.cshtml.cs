using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Elias.Data.Entities;

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
        public LoginDto login { get; set; }

        public IActionResult OnGet()
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

             var user =  _userService.Login(login);
            if (user != null)
            {
                if (user.IsActive)
                {
                    #region LoginClaims
                    var claims = new List<Claim>()
                      {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.UserName),
                      };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties { IsPersistent = true };

                    await HttpContext.SignInAsync(principal, properties);
                    return RedirectToPage("Index");
                    #endregion
                }
            }

            return Page();
        }
    }
}
