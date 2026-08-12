using System.Net.Http; using System.Threading.Tasks;
public class Sk13UrlAllowlistWrongTp {
  public async Task Run(string url) {
    var v = url.Replace("http://", "https://"); // wrong
    await new HttpClient().GetAsync(v); // SINK
  }
}
