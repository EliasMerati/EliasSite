using Elias.Application.Interfaces;
using Elias.Application.Services;
using Elias.Common;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Elias.Admin.Configuration
{
    public static class DiConfiguration
    {
        public static void Configuration(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISkillGroupService, SkillGroupService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<ICertificateService, CertificateService>();
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<IPortfolioGroupService, PortfolioGroupService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogGroupService, BlogGroupService>();
            services.AddScoped<IBlogCommentService, BlogCommentService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IViewRenderService, RenderViewToString>();
            
        }
    }
}
