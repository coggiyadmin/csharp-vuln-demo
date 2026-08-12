using System.Net.Http; using System.Threading.Tasks;
public class V30HttpRequestMessageTp {
  public async Task Run(string url) {
    var u = url + "/x";
    await new HttpClient().SendAsync(new HttpRequestMessage(HttpMethod.Get, u)); // SINK
  }
}
