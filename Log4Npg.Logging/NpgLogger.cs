using Newtonsoft.Json;
using System;
using Log4Npg.Models;
using Log4Npg.Logging.Data;

namespace Log4Npg.Logging
{
    public class NpgLogger : INpgLogger
    {
        private readonly ILoggingRepository _loggingRepository;
        public NpgLogger(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        public void LogDebug(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Debug);
            _loggingRepository.AddLogEntry(logEntry);
        }
        public void LogInfo(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Info);
            _loggingRepository.AddLogEntry(logEntry);
        }
        public void LogWarning(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Warn);
            _loggingRepository.AddLogEntry(logEntry);
        }
        public void LogError(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Error);
            _loggingRepository.AddLogEntry(logEntry);
        }
        public void LogFatal(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Fatal);
            _loggingRepository.AddLogEntry(logEntry);
        }

        private LogEntry BuildLogEntry(object message, LogLevel level)
        {
            return new LogEntry
            {
                Level = level,
                EventTime = DateTime.UtcNow,
                Message = JsonConvert.SerializeObject(message)
            };
        }
    }
}
