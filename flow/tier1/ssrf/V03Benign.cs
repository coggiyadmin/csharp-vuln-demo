using System.Net.Http;
public class V03Benign {
  public async Task Run() => await new HttpClient().GetStringAsync("https://api.internal.example.com/health");
}
