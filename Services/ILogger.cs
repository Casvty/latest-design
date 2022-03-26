using System.Threading.Tasks;

namespace test_design.Services
{
    public interface ILogger
    {
        Task<bool> LoggAsync(string serviceName, string loggEventType, string message);
    }
}