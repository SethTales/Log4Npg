using Ductus.FluentDocker;
using Ductus.FluentDocker.Builders;
using Ductus.FluentDocker.Services;
using NUnit.Framework;
using Log4Npg.Logging.Data;
using Log4Npg.Logging.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Diagnostics;

namespace Log4Npg.Tests.IntegrationTests
{
    public class NpgLoggerTests
    {
        private ICompositeService _container;
        private TestDatabaseContext _dbContext;
        private ILoggingRepository _loggingRepository;
        private INpgLogger _npgLogger;
        private ServiceCollection _services;
        private const string TestConnectionString = "User ID=postgres;Password=postgres;server=localhost;Port=5432";


        [OneTimeSetUp]
        public void InitTestFixture()
        {
            var info = new ProcessStartInfo("bash", $"{Path.Combine(Directory.GetCurrentDirectory(), "Scripts/create_test_db.sh")}");
            Process p = Process.Start(info);
            p.WaitForExit();
            
            var optionsBuilder = new DbContextOptionsBuilder<LoggingDatabaseContext>();
            optionsBuilder.UseNpgsql(TestConnectionString);

            using (var context = new TestDatabaseContext(optionsBuilder.Options))
            {
                context.ExecuteDatabaseMigration();
            }
        }

        [OneTimeTearDown]
        public void TearDownTestFixture()
        {
            var info = new ProcessStartInfo("bash", $"{Path.Combine(Directory.GetCurrentDirectory(), "Scripts/teardown_test_db.sh")}");
            Process p = Process.Start(info);
            p.WaitForExit();
        }

        [Test]
        public void IntegrationFixtureWorks()
        {
            Assert.AreEqual(0, 0);
        }

        
    }
}