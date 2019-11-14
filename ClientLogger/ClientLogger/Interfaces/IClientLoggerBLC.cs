using System.Threading.Tasks;

public interface IClientLoggerBLC
{
    Task<ClientInfo> LogInformation(ClientInfo info);
}