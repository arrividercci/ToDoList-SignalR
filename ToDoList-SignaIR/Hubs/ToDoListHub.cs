using Microsoft.AspNetCore.SignalR;

namespace ToDoList_SignaIR.Hubs
{
    public class ToDoListHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Send", message);
        }
    }
}
