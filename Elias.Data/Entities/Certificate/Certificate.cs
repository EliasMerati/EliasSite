using Elias.Data.Common;

namespace Elias.Data.Entities.Certificate
{
    public class Certificate : BaseEntity<int>
    {
        public string CertificateName { get; set; }
        public string CertificateDate { get; set; }
        public string CertificateID { get; set; }
        public string CertificateImage { get; set; }
    }
}
