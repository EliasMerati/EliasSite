using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Education
{
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
        public void OnGet()
        {
        }
    }
}
