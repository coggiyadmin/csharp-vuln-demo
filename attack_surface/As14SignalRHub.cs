using Microsoft.AspNetCore.SignalR;
public class As14SignalRHub : Hub {
  public async Task Broadcast(string html) => await Clients.All.SendAsync("msg", html); // SINK
}
