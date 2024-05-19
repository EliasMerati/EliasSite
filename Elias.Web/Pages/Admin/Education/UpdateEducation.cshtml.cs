using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
    [PermissionChecker(16)]
    public class UpdateEducationModel : PageModel
    {
        #region Inject Service
        private readonly IEducationService _educationService;
        public UpdateEducationModel(IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Education.Education education { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            education = await _educationService.FindEducationById(Id);
            if (education == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                await _educationService.UpdateEducation(education);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
