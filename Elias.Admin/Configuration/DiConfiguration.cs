using Elias.Application.Interfaces;
using Elias.Application.Services;

namespace Elias.Admin.Configuration
{
    public static class DiConfiguration
    {
        public static void Configuration(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
