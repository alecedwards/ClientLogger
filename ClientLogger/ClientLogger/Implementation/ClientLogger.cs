using System.Threading.Tasks;
using ClientLogger.Interfaces;

namespace ClientLogger.Implementation
{
    public class ClientLoggerBLC : IClientLoggerBLC
    {
        private IClientLoggerDAO dao;
        public ClientLoggerBLC(IClientLoggerDAO dao)
        {
            this.dao = dao;
        }
        public async Task<ClientInfo> LogInformation(ClientInfo info)
        {
            return await dao.LogInformation(info);
            throw new System.NotImplementedException();
        }
    }
}