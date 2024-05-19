using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Experience
{
    [PermissionChecker(21)]
    public class RemoveExperienceModel : PageModel
    {
        #region Inject Service
        private readonly IExperienceService _experienceService;
        public RemoveExperienceModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Experience.Experience experience { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            try
            {
                experience = await _experienceService.FindExperienceById(Id);
                await _experienceService.DeleteExperience(experience);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
