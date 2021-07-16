using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, string message)
		{
            await Clients.All.SendAsync("message", name, message);
		}
    }
}
