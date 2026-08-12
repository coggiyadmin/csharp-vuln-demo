using System.Net.Http;
using System.Threading.Tasks;
public class Sk05HostAllowlistSsrfSafe {
  public async Task Run(string url) {
    if (new System.Uri(url).Host != "api.internal.example.com") return;
    await new HttpClient().GetAsync(url);
  }
}
