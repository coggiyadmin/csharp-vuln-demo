// SAFE — ssrf: fixed BaseAddress, redirects off, relative path only
using System.Net.Http;
using System.Threading.Tasks;
public class V07HardeningSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    var handler = new HttpClientHandler { AllowAutoRedirect = false };
    var client = new HttpClient(handler) { BaseAddress = new System.Uri("https://api.internal.example.com/") };
    var relative = "lookup/" + System.Uri.EscapeDataString(input);
    await client.GetAsync(relative);
  }
}
