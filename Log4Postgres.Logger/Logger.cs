using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Log4Postgres.Models;
using Log4Postgres.Logger.Data;

namespace Log4Postgres.Logger
{
    public class PLogger : ILogger
    {
        private readonly ILoggingRepository _loggingRepository;
        public PLogger(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }

        public async Task LogDebug(object message)
        {
            var logEntry = BuildLogEntry(message, LogLevel.Debug);
            await _loggingRepository.AddLogEntryAsync(logEntry);
        }
        public async Task LogInfo(object message)
        {
            throw new NotImplementedException();
        }
        public async Task LogWarning(object message)
        {
            throw new NotImplementedException();
        }
        public async Task LogError(object message)
        {
            throw new NotImplementedException();
        }
        public async Task LogFatal(object message)
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
