using System.Net.Http;
/** TN — SSRF host allowlist. */
public class BenignHostAllowlist {
  public async Task Run(string url) {
    if (new Uri(url).Host == "api.internal.example.com")
      await new HttpClient().GetAsync(url);
  }
}
