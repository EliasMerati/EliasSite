using Elias.Data.Common;

namespace Elias.Data.Entities.Skills
{
    public class SkillGroup : BaseEntity<int>
    {
        public string SkillGroupName { get; set; }

        #region Navigation Property
        public ICollection<Skill> Skills { get; set; }
        #endregion
    }
}
