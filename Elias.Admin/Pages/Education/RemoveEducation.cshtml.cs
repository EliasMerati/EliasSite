using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
    [PermissionChecker(16)]
    public class RemoveEducationModel : PageModel
    {
        #region Inject Service
        private readonly IEducationService _educationService;
        public RemoveEducationModel(IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Education.Education education { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            education = await _educationService.FindEducationById(Id);
            await _educationService.DeleteEducation(education);
            return RedirectToPage("Index");
        }
    }
}
