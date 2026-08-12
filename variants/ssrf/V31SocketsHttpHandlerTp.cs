using System.Net.Http; using System.Threading.Tasks;
public class V31SocketsHttpHandlerTp {
  public async Task Run(string url) {
    var c = new HttpClient(new SocketsHttpHandler());
    await c.GetStringAsync(url); // SINK CWE-918
  }
}
