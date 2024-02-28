using Elias.Application.Interfaces;
using Elias.Data.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.User
{
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


        public UpdateUserDto user { get; set; }

        public async Task<IActionResult> OnGet(int Id)
        {
            user = await _userService.FindUserForUpdateAsync(Id);
            if (user == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPost(UpdateUserDto newuser, IFormFile Image, IFormFile Resumeh)
        {
            #region Validation
            if (!ModelState.IsValid)
            {
                return Page();
            }

            #endregion
            user.Address = newuser.Address;
            user.Password = newuser.Password;
            user.PhoneNumber = newuser.PhoneNumber;
            user.Familly = newuser.Familly;
            user.City = newuser.City;
            user.Ostan = newuser.Ostan;
            user.Skype = newuser.Skype;
            user.Skills = newuser.Skills;
            user.Email = newuser.Email;
            user.Name = newuser.Name;
            user.UserName = newuser.UserName;
            user.GitHub = newuser.GitHub;
            user.LinkedIn = newuser.LinkedIn;
            user.MainDescription = newuser.MainDescription;
            user.MainSkill = newuser.MainSkill;
            user.ShortDescription = newuser.ShortDescription;
            user.IsActive = newuser.IsActive;

            await _userService.UpdateUser(user, Image, Resumeh);
            return Redirect("Index");
        }
    }
}
