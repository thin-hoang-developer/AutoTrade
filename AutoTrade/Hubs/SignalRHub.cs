using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace AutoTrade.Hubs
{
    public class SignalRHub : Hub
    {
        [HubMethodName("broadcastData")]
        public static void BroadcastData()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
            context.Clients.All.updatedData();
        }
    }
}