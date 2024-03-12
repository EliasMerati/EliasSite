using Elias.Data.DTOs;
using Elias.Data.Entities.Certificate;
using Microsoft.AspNetCore.Http;

namespace Elias.Application.Interfaces
{
    public interface ICertificateService
    {
        Task<Certificate> FindCertificateById(int id);
        List<CertificateDto> GetCertificateList();
        Task UpdateCertificate(Certificate certificate, IFormFile Img);
        Task CreateCertificate(Certificate certificate, IFormFile Img);
        Task DeleteCertificate(Certificate certificate);
        bool IsCertificateExist();
    }
}
