using System.Net.Http;
public class BenignFlow {
  public async Task Run() {
    await new HttpClient().GetAsync("https://api.internal.example.com/health");
  }
}
