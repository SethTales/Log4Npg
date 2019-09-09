using Log4Npg.Models;

namespace Log4Npg.Logging.Data
{
    public interface ILoggingRepository
    {
        LogEntry AddLogEntry(LogEntry logEntry);
    }
}