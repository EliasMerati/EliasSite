using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    public class CreateCertificateModel : PageModel
    {
        #region Inject Service
        private readonly ICertificateService _certificateService;
        public CreateCertificateModel(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.DTOs.CertificateDto certificate { get; set; }
        public void OnGet()
        {
        }
    }
}
