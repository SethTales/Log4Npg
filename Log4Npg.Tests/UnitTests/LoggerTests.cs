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

        [TestCase("LogDebug", LogLevel.Debug)]
        [TestCase("LogInfo", LogLevel.Info)]
        [TestCase("LogWarning", LogLevel.Warn)]
        [TestCase("LogError", LogLevel.Error)]
        [TestCase("LogFatal", LogLevel.Fatal)]
        public void EachLoggingMethod_CallsLoggingRepository_WithCorrectLogLevelEnum(string methodName, LogLevel level)
        {
            var type = _logger.GetType();
            var logMethod = type.GetMethod(methodName);
            var logMessage = "this is a test message";
            logMethod.Invoke(_logger, new object[] {logMessage});
            _loggingResitory.Received(1).AddLogEntry(Arg.Is<LogEntry>(x =>
                x.Level == level));
        }

    }
}