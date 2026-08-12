using System.Net.WebSockets; using System.Text; using System.Threading.Tasks;
public class As13WebsocketHandler {
  public async Task Echo(WebSocket ws, string msg) {
    var bytes = Encoding.UTF8.GetBytes(msg);
    await ws.SendAsync(bytes, WebSocketMessageType.Text, true, default); // reflected WS
  }
}
