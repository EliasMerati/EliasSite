using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Context;
using Elias.Data.DTOs;
using Elias.Data.Entities;
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


        public async Task CreateCertificate(Certificate certificate, IFormFile Img)
        {
            await AddCertificateImage(certificate, Img);
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
                .Select(c => new CertificateDto()
                {
                    CertificateDate = c.CertificateDate,
                    CertificateID = c.CertificateID,
                    CertificateName = c.CertificateName,
                    CertificateImage = c.CertificateImage,
                    Id = c.Id,
                }).AsNoTracking().ToList();
        }

        public bool IsCertificateExist()
        {
            return _db.Certificates.Any();
        }

        private async Task UpdateCertificateImage(Certificate certificate, IFormFile Image)
        {
            if (Image is not null)
            {
                if (certificate.CertificateImage is null)
                {
                    certificate.CertificateImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory()/*.Remove(30)*/, "wwwroot/Certificate/", certificate.CertificateImage);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
                else
                {
                    var DeleteResumehPath = Path.Combine(Directory.GetCurrentDirectory()/*.Remove(30)*/, "wwwroot/Certificate/", certificate.CertificateImage);
                    if (File.Exists(DeleteResumehPath))
                    {
                        File.Delete(DeleteResumehPath);
                    }

                    certificate.CertificateImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory()/*.Remove(30)*/, "wwwroot/Certificate/", certificate.CertificateImage);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
            }
        }

        private async Task AddCertificateImage(Certificate certificate, IFormFile Image)
        {
            if (Image is not null)
            {
                certificate.CertificateImage = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                string Imagepath = Path.Combine(Directory.GetCurrentDirectory()/*.Remove(30)*/, "wwwroot/Certificate/", certificate.CertificateImage);
                using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                {

                    Image.CopyTo(stream);
                }
            }
        }

        public async Task UpdateCertificate(Certificate certificate, IFormFile Img)
        {
            await UpdateCertificateImage(certificate, Img);
            _db.Update(certificate);
            await _db.SaveChangesAsync();
        }
    }
}
