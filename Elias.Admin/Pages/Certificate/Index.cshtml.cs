using Elias.Application.Interfaces;
using Elias.Data.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    public class IndexModel : PageModel
    {
        #region Inject Service
        private readonly ICertificateService _certificateService;

        public IndexModel(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        #endregion

        public List<CertificateDto> certificates { get; set; }
        public void OnGet()
        {
            certificates = _certificateService.GetCertificateList();
        }
    }
}
