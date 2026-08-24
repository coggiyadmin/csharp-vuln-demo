// SAFE — Ssrf sanitizer, applied late, immediately before the sink — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San11DelayedEncodeSsrfSafe {
  public async Task Run(string input) {
    var t = input;
    var length = t.Length;
    var v = System.Uri.EscapeDataString(t);
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
