using Elias.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Elias.Application.Attribute
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private  IPermissionService _permissionService;
        int permissionId = 0;
        public PermissionCheckerAttribute(int permissionId)
        {
            this.permissionId = permissionId;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService = (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = context.HttpContext.User.Identity.Name;
                if (!_permissionService.CheckPermission(permissionId,userName))
                {
                    context.Result = new RedirectResult("/Login?" + context.HttpContext.Request.Path);
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
