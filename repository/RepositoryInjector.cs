using Microsoft.Extensions.DependencyInjection;
using repository.Implementations;

namespace repository
{
    public static class RepositoryInjector
    {
        public static void InjectRespositories(this IServiceCollection services)
        {
            services.AddTransient<IChatterRepository, ChatterRepository>();
        }
    }
}
