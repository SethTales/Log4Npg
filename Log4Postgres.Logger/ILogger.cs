using System.Threading.Tasks;

namespace Log4Postgres
{
    public interface ILogger
    {
        Task LogDebug(object message);
        Task LogInfo(object message);
        Task LogWarning(object message);
        Task LogError(object message);
        Task LogFatal(object message);
    }
}