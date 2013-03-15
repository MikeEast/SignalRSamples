using Microsoft.AspNet.SignalR;

namespace SignalRSamples.Web.Hubs
{
    public class SimpleHub : Hub
    {
        public void SendAll(string message)
        {
            Clients.All.notify(message);
        }

        public void SendAllExceptSelf(string message)
        {
            Clients.Others.notify(message);
        }
    }
}