using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IEducationService _educationService;
        public IndexModel(IEducationService educationService)
        {
            _educationService = educationService;
        }
        #endregion
        [BindProperty]
        public List<Elias.Data.DTOs.EducationDto> educations { get; set; }
        public void OnGet()
        {
            educations = _educationService.GetEducationList();
        }
    }
}
