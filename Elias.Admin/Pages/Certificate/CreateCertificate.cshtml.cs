using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    [PermissionChecker(22)]
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
        public Data.Entities.Certificate.Certificate certificate { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IFormFile ImgCertificate)
        {
           await _certificateService.CreateCertificate(certificate, ImgCertificate);
            return RedirectToPage("Index");
        }
    }
}
