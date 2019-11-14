using System.Threading.Tasks;

namespace ClientLogger.Interfaces
{
    public interface IClientLoggerDAO
    {
        Task<ClientInfo> LogInformation(ClientInfo info);
    }
}