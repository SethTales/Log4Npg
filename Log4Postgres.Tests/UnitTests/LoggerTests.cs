using NUnit.Framework;
using NSubstitute;
using System.Threading.Tasks;
using Log4Postgres.Logger.Data;
using Log4Postgres.Logger;
using Log4Postgres.Models;

namespace Log4Postgres.Tests.UnitTests
{
    [TestFixture]
    public class LoggerTests
    {
        private ILoggingRepository _loggingResitory;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            _loggingResitory = Substitute.For<ILoggingRepository>();
            _logger = new PLogger(_loggingResitory);
        }

        [Test]
        public async Task LogDebug_CallsLoggingRepositoryMethod()
        {
            var logMessage = "this is a test message";
            await _logger.LogDebug(logMessage);
            await _loggingResitory.Received(1).AddLogEntryAsync(Arg.Is<LogEntry>(x =>
                x.Level == LogLevel.Debug));
        }

    }
}