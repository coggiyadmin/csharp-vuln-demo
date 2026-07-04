using System.Net.Http;
public class V02Safe {
  public async Task Run(string url) {
    var host = new Uri(url).Host;
    if (host == "api.internal.example.com") await new HttpClient().GetStringAsync(url);
  }
}
