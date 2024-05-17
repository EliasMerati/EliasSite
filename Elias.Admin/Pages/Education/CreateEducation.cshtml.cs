using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
    [PermissionChecker(15)]
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
            try
            {
                await _educationService.CreateEducation(education);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
