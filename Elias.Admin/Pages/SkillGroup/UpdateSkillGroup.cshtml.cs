using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.SkillGroup
{
    [PermissionChecker(8)]
    public class UpdateSkillGroupModel : PageModel
    {
        #region Inject Service
        private readonly ISkillGroupService _skillGroupService;
        public UpdateSkillGroupModel(ISkillGroupService skillGroupService)
        {
            _skillGroupService = skillGroupService;
        }
        #endregion

        [BindProperty]
        public Elias.Data.Entities.Skills.SkillGroup skillGroup { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            skillGroup = await _skillGroupService.FindById(Id);
            if (skillGroup == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            await _skillGroupService.UpdateSkillGroup(skillGroup);
            return RedirectToPage("Index");
        }
    }
}
