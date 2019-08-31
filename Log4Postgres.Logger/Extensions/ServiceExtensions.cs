using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Log4Postgres.Logger.Data;

namespace Log4Postgres.Logger.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddLoggingScoped(this IServiceCollection services, string connectionString)
        {
            services
                .AddEntityFrameworkNpgsql()
                .AddDbContext<LoggingDatabaseContext>(options =>
                    options.UseNpgsql(connectionString));
            services.AddScoped<ILoggingRepository, LoggingRepository>();
            services.AddScoped<ILogger, PLogger>();
        }
    }
}