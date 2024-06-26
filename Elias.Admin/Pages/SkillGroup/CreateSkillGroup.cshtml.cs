using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.SkillDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.SkillGroup
{
    [PermissionChecker(8)]
    public class CreateSkillGroupModel : PageModel
    {
        #region Inject Service
        private readonly ISkillGroupService _skillGroupService;
        public CreateSkillGroupModel(ISkillGroupService skillGroupService)
        {
            _skillGroupService = skillGroupService;
        }
        #endregion

        [BindProperty]
        public SkillGroupDto skillGroup { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                await _skillGroupService.AddSkillGroup(skillGroup);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
