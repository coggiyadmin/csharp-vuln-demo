using System.Net.Http;
/** FP-target — constant URL. */
public class SafeHttpAllowlisted {
  public async Task Run() => await new HttpClient().GetAsync("https://api.internal.example.com/health");
}
