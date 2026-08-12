using System.Net.Http;
public class V02Safe {
  public async Task Run(string input) {
    var host = new Uri(input).Host;
        if (host == "api.internal.example.com") await new HttpClient().GetAsync(input);
  }
}
