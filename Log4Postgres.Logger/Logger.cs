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

        public async Task LogDebug(string message)
        {
            throw new NotImplementedException();
        }
        public async Task LogInfo(string message)
        {
            throw new NotImplementedException();
        }
        public async Task LogWarning(string message)
        {
            throw new NotImplementedException();
        }
        public async Task LogError(string message)
        {
            throw new NotImplementedException();
        }
        public async Task LogFatal(string message)
        {
            throw new NotImplementedException();
        }
    }
}
