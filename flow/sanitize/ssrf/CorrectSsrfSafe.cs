using System.Net.Http;
public class CorrectSsrfSafe {
  public async Task Run(string q) {
    var host = new Uri(q).Host;
        if (host == "api.internal.example.com") await new HttpClient().GetAsync(q);
  }
}
