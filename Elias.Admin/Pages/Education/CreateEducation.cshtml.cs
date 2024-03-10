using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
    public class CreateEducationModel : PageModel
    {
        #region Inject Service
        private readonly IEducationService _educationService;
        public CreateEducationModel(IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Education.Education education { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _educationService.CreateEducation(education);
            return RedirectToPage("Index");
        }
    }
}
