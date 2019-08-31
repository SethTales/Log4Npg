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
            throw new NotImplementedException();
        }
        public void LogWarning(object message)
        {
            throw new NotImplementedException();
        }
        public void LogError(object message)
        {
            throw new NotImplementedException();
        }
        public void LogFatal(object message)
        {
            throw new NotImplementedException();
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
