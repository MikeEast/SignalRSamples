using Microsoft.AspNet.SignalR;

namespace SignalRSamples.Web.Hubs
{
    public class GroupsHub : Hub
    {
        public void JoinGroup(string groupName)
        {
            Groups.Add(Context.ConnectionId, groupName);
        }

        public void LeaveGroup(string groupName)
        {
            Groups.Remove(Context.ConnectionId, groupName);
        }

        public void SendToGroup(string groupName, string message)
        {
            Clients.Group(groupName).notify(groupName, message);
        }
    }
}