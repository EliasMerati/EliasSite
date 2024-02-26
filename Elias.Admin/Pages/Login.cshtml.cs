using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Elias.Admin.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        #region Injection

        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        
        public LoginDto login { get; set; }
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

            await _userService.Login(login);

            if (User != null)
            {
                #region LoginClaims
                var user = _userService.GetByEmail(login.Email);
                var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,$"{user.Result.Name} {user.Result.Familly}"),
                new Claim(ClaimTypes.MobilePhone,user.Result.PhoneNumber),
                new Claim(ClaimTypes.Surname,user.Result.UserName),
            };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties { IsPersistent = true };

                await HttpContext.SignInAsync(principal, properties);
                #endregion
            }


            return Page();
        }
    }
}
