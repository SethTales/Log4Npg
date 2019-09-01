using Microsoft.EntityFrameworkCore;
using System.Linq;
using Log4Npg.Logging.Data;

namespace Log4Npg.Tests.IntegrationTests
{
    public class TestDatabaseContext : LoggingDatabaseContext
    {
        public TestDatabaseContext(DbContextOptions<LoggingDatabaseContext> options) : base (options)
        {

        }

        public void ExecuteDatabaseMigration()
        {
            if (Database.GetPendingMigrations().Any())
            {
                Database.Migrate();
            }
        }

        public void DeleteTestData(string[] tableNames)
        {
            foreach (var table in tableNames)
            {
                Database.ExecuteSqlCommand($"TRUNCATE TABLE {table}");
            }
        }
    }
}