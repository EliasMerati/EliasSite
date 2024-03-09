using Elias.Application.Interfaces;
using Elias.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Elias.Admin.Pages.Skill
{
    public class UpdateSkillModel : PageModel
    {
        #region Inject Service
        private readonly ISkillService _skillService;
        private readonly ISkillGroupService _skillGroupService;
        public UpdateSkillModel(ISkillService skillService, ISkillGroupService skillGroupService)
        {
            _skillService = skillService;
            _skillGroupService = skillGroupService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Skills.Skill Skill { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            var groups = _skillGroupService.GetSkillGroup();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            Skill = await _skillService.FindSkillById(Id);
            if (Skill == null)
                return NotFound();
            return Page();
            
        }

        public async Task<IActionResult> OnPost()
        {
            await _skillService.UpdateSkill(Skill);
            return RedirectToPage("Index");
        }
    }
}
