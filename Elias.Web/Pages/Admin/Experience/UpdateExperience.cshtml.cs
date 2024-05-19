using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Experience
{
    [PermissionChecker(20)]
    public class UpdateExperienceModel : PageModel
    {
        #region Inject Service
        private readonly IExperienceService _experienceService;
        public UpdateExperienceModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Experience.Experience experience { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            experience = await _experienceService.FindExperienceById(Id);
            if (experience == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                await _experienceService.UpdateExperience(experience);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
