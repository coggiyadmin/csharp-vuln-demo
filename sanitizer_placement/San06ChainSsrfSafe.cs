// SAFE — Ssrf sanitizer, applied at the end of a call chain — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San06ChainSsrfSafe {
  public async Task Run(string input) {
    var v = System.Uri.EscapeDataString(input.Trim().ToLowerInvariant());
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
