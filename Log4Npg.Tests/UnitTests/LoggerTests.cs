using NUnit.Framework;
using NSubstitute;
using Log4Npg.Logging.Data;
using Log4Npg.Logging;
using Log4Npg.Models;

namespace Log4Npg.Tests.UnitTests
{
    [TestFixture]
    public class LoggerTests
    {
        private ILoggingRepository _loggingResitory;
        private INpgLogger _logger;

        [SetUp]
        public void Setup()
        {
            _loggingResitory = Substitute.For<ILoggingRepository>();
            _logger = new NpgLogger(_loggingResitory);
        }

        [Test]
        public void LogDebug_CallsLoggingRepositoryMethod()
        {
            var logMessage = "this is a test message";
            _logger.LogDebug(logMessage);
            _loggingResitory.Received(1).AddLogEntry(Arg.Is<LogEntry>(x =>
                x.Level == LogLevel.Debug));
        }

    }
}