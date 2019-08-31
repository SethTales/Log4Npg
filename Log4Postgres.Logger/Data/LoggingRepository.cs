using Log4Postgres.Models;
using System.Threading.Tasks;

namespace Log4Postgres.Logger.Data
{
    public class LoggingRepository : ILoggingRepository
    {
        private readonly LoggingDatabaseContext _dbContext;

        public LoggingRepository(LoggingDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddLogEntryAsync(LogEntry logEntry)
        {
            await _dbContext.LogEntries.AddAsync(logEntry);
            await _dbContext.SaveChangesAsync();
        }
    }
}