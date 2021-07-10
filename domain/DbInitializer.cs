using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace domain
{
    public static class DbInitializer
    {
        private static string GetConnectionString(string DATABASE_URL)
        {
            var databaseUrl = DATABASE_URL.Replace("//", string.Empty);
            char[] delimiterChars = { '/', ':', '@', '?' };
            string[] strConn = databaseUrl.Split(delimiterChars);
            strConn = strConn.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var user = strConn[1];
            var password = strConn[2];
            var server = strConn[3];
            var port = strConn[4];
            var database = strConn[5];

            var connectionString = $"host={server};port={port};database={database};uid={user};pwd={password};sslmode=Require;Trust Server Certificate=true;Timeout=1000";

            return connectionString;
        }

        public static void InjectDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
            databaseUrl = string.IsNullOrEmpty(databaseUrl) ? configuration["ConnectionStrings:DATABASE_URL"] : databaseUrl;
            services.AddDbContext<OBotFactoryContext>(options => options.UseNpgsql(GetConnectionString(databaseUrl), b => b.MigrationsAssembly("api")), ServiceLifetime.Transient);
        }

    }
}
