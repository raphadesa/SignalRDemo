using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemo
{
    public class BroadcastHub : Hub
    {
        public async Task SendNotify()
        {
            await Clients.All.SendAsync("Notify");
        }
    }
}
