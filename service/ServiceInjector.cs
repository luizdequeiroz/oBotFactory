using Microsoft.Extensions.DependencyInjection;
using repository;
using service.Implementations;

namespace service
{
    public static class ServiceInjector
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.InjectRespositories();
            services.AddTransient<IChatterService, ChatterService>();
        }
    }
}
