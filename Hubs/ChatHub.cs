using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message,string user)
        {
            Clients.All.SendAsync("ReceiveMessage",message, user);
        }
    }
}
