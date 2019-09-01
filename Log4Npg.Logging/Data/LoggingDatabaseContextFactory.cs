using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Log4Npg.Logging.Data
{
    public class LoggingDatabaseContextFactory : IDesignTimeDbContextFactory<LoggingDatabaseContext>
    {
        public LoggingDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LoggingDatabaseContext>();
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;server=localhost;Port=5432");

            return new LoggingDatabaseContext(optionsBuilder.Options);
        }
    }
}