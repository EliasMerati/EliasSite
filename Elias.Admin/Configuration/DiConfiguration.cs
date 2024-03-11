using Elias.Application.Interfaces;
using Elias.Application.Services;

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
        }
    }
}
