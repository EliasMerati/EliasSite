using Elias.Application.Attribute;
using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elias.Admin.Pages.Certificate
{
    [PermissionChecker(25)]
    public class RemoveCertificateModel : PageModel
    {
        #region Inject Service
        private readonly ICertificateService _certificateService;

        public RemoveCertificateModel(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        #endregion

        [BindProperty]
        public Elias.Data.Entities.Certificate.Certificate certificate { get; set; }
        public async Task<IActionResult> OnGet(int Id)
        {
            try
            {
                certificate = await _certificateService.FindCertificateById(Id);
                await _certificateService.DeleteCertificate(certificate);
                return RedirectToPage("Index");
            }
            catch (Exception b)
            {
                return Content(b.Message);
            }
            
        }
    }
}
