using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRSamples.Web.Hubs
{
    public class MovrHub : Hub
    {
        public void Move(int x, int y)
        {
            Clients.Others.moved(x, y);
        }
    }
}