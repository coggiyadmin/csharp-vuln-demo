using Microsoft.AspNetCore.SignalR;
public class SignalrXssTp : Hub {
  public async System.Threading.Tasks.Task Broadcast(string html) =>
    await Clients.All.SendAsync("msg", html); // SINK
}
