using Elias.Application.Interfaces;
using Elias.Data.Context;
using Elias.Data.DTOs;
using Elias.Data.Entities.Certificate;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class CertificateService : ICertificateService
    {
        #region Inject Database
        private readonly DatabaseContext _db;
        public CertificateService(DatabaseContext db)
        {
            _db = db;
        }
        #endregion


        public async Task CreateCertificate(CertificateDto certificate, IFormFile Img)
        {
            _db.Add(certificate);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteCertificate(Certificate certificate)
        {
            _db.Remove(certificate);
            await _db.SaveChangesAsync();
        }

        public async Task<Certificate> FindCertificateById(int id)
        {
            return await _db.Certificates.FindAsync(id);
        }

        public List<CertificateDto> GetCertificateList()
        {
            return _db.Certificates
                .Select(c=> new CertificateDto()
                {
                    CertificateDate = c.CertificateDate,
                    CertificateID = c.CertificateID,
                    CertificateName = c.CertificateName,
                    Id = c.Id,
                }).AsNoTracking().ToList();
        }

        public bool IsCertificateExist()
        {
            return _db.Certificates.Any();
        }

        public async Task UpdateCertificate(Certificate certificate, IFormFile Img)
        {
            _db.Update(certificate);
            await _db.SaveChangesAsync();
        }
    }
}
