using System.Threading.Tasks;

namespace Log4Postgres
{
    public interface ILogger
    {
        Task LogDebug(string message);
        Task LogInfo(string message);
        Task LogWarning(string message);
        Task LogError(string message);
        Task LogFatal(string message);
    }
}