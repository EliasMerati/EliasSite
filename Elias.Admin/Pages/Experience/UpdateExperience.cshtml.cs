using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Experience
{
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
        public async void OnGet(int Id)
        {
            experience = await _experienceService.FindExperienceById(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            await _experienceService.UpdateExperience(experience);
            return RedirectToPage("Index");
        }
    }
}
