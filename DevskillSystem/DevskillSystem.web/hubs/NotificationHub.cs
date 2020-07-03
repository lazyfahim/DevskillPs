using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace DevskillSystem.web.hubs
{
    public class NotificationHub:Hub
    {
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}