// SAFE — Ssrf sanitizer, applied by reassigning the same variable — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San12ReassignSsrfSafe {
  public async Task Run(string input) {
    var v = input;
    v = System.Uri.EscapeDataString(v);
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
