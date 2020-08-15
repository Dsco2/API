using System.Threading.Tasks;
using FinApp_V2.Models;

namespace FinApp_V2.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
