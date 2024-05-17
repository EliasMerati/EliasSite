using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    [PermissionChecker(24)]
    public class UpdateCertificateModel : PageModel
    {
        #region Inject Service
        private readonly ICertificateService _certificateService;
        public UpdateCertificateModel(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        #endregion
        [BindProperty]
        public Elias.Data.Entities.Certificate.Certificate certificate { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            certificate = await _certificateService.FindCertificateById(Id);
            if (certificate == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(IFormFile ImgCertificate)
        {
            try
            {
                await _certificateService.UpdateCertificate(certificate, ImgCertificate);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
