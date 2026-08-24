// SAFE — Ssrf sanitizer, applied to a truncated copy of the input — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San05PartialStripSsrfSafe {
  public async Task Run(string input) {
    var t = input.Length > 64 ? input.Substring(0, 64) : input;
    var v = System.Uri.EscapeDataString(t);
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
