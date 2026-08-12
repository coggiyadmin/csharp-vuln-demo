using System.Net.Http;
using System.Threading.Tasks;
// named for parity with py safe_fastapi_allowlist
public class SafeFastapiAllowlist {
  public async Task Run(string host) {
    if (host != "api.internal.example.com") return;
    await new HttpClient().GetAsync("https://" + host + "/health");
  }
}
