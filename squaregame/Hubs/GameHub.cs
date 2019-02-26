using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SquareGame.Hubs
{
    public class GameHub : Hub
    {
        public async Task ClickSide(string player, int x, int y, int i)
        {
            await Clients.Others.SendAsync("UpdateBoard", player, x, y, i);
        }
    }
}