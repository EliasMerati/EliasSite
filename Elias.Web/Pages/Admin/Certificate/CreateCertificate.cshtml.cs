using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    [PermissionChecker(23)]
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
            try
            {
                await _certificateService.CreateCertificate(certificate, ImgCertificate);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
