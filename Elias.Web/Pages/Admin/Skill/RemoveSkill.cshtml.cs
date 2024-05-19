using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Skill
{
    [PermissionChecker(13)]
    public class RemoveSkillModel : PageModel
    {
        #region Inject Service
        private readonly ISkillService _skillService;
        public RemoveSkillModel(ISkillService skillService)
        {
            _skillService = skillService;  
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Skills.Skill Skill { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            try
            {
                Skill = await _skillService.FindSkillById(Id);
                await _skillService.DeleteSkill(Skill);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
