using System.Threading.Tasks;
using Log4Postgres.Models;

namespace Log4Postgres.Logger.Data
{
    public interface ILoggingRepository
    {
        Task AddLogEntryAsync(LogEntry logEntry);
    }
}