using Elias.Application.Interfaces;
using Elias.Data.DTOs.SkillDto;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Skill
{
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly ISkillService _skillService;
        public IndexModel(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public List<SkillDto> Skills { get; set; }
        #endregion
        public void OnGet()
        {
            Skills = _skillService.GetSkillList();
        }
    }
}
