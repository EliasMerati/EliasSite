using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Elias.Data.DTOs.SkillDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.SkillGroup
{
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        #region MyRegion
        private readonly ISkillGroupService _skillGroupService;
        public IndexModel(ISkillGroupService skillGroupService)
        {
            _skillGroupService = skillGroupService;   
        }
        #endregion
        public List<SkillGroupDto> SkillGroups { get; set; }
        public async void OnGet()
        {
            SkillGroups =  _skillGroupService.GetAllSkillGroup();
        }
    }
}
