using System.Net.Http; using System.Threading.Tasks;
public class Sk13UrlAllowlistSafe {
  public async Task Run(string url) {
    if (new System.Uri(url).Host != "cdn.example.com") return;
    await new HttpClient().GetAsync(url);
  }
}
