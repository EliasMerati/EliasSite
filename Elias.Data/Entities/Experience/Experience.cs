using Elias.Data.Common;

namespace Elias.Data.Entities.Experience
{
    public class Experience : BaseEntity<int>
    {
        public string ExperienceSubject { get; set; }
        public string ExperienceDate { get; set; }
        public string Description { get; set; }
    }
}
