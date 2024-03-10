using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Experience
{
    public class AddExperienceModel : PageModel
    {

        #region Inject Service
        private readonly IExperienceService _experienceService;
        public AddExperienceModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Experience.Experience experience { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _experienceService.CreateExperience(experience);
            return RedirectToPage("Index");
        }
    }
}
