using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Experience
{
    [PermissionChecker(18)]
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly IExperienceService _experienceService;
        public IndexModel(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        #endregion
        [BindProperty]
        public List<Elias.Data.DTOs.ExperienceDto> experiences { get; set; }
        public void OnGet()
        {
            experiences = _experienceService.GetExperienceList();
        }
    }
}
