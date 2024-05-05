using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.SkillDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Admin.Pages.Skill
{
    [PermissionChecker(10)]
    [BindProperties]
    public class CreateSkillModel : PageModel
    {
        #region Inject Service
        private readonly ISkillGroupService _skillGroupService;
        private readonly ISkillService _skillService;
        public CreateSkillModel(ISkillGroupService skillGroupService, ISkillService skillService)
        {
            _skillGroupService = skillGroupService;
            _skillService = skillService;
        }
        #endregion

        
        public Elias.Data.Entities.Skills.Skill Skill { get; set; }
        public void OnGet()
        {
            var groups = _skillGroupService.GetSkillGroup();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
        }

        public async Task<IActionResult> OnPost()
        {
            await _skillService.CreateSkill(Skill);
            return RedirectToPage("Index");
        }
    }
}
