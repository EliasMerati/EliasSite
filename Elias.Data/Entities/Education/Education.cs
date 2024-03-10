using Elias.Data.Common;

namespace Elias.Data.Entities.Education
{
    public class Education : BaseEntity<int>
    {
        public string EducationCertificate { get; set; }
        public string Since { get; set; }
        public string Description { get; set; }
    }
}
