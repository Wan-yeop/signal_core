using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace MySignalRCoreApp.Hubs
{

    public class ChatHub : Hub
    {
        private static ConcurrentDictionary<string, DateTime> ConnectedUsers
            = new ConcurrentDictionary<string, DateTime>();

        // 새로운 접속이 이루어지면 사용자 정보를 모든 사용자에게 전송
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
