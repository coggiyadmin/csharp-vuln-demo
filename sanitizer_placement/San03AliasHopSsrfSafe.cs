// SAFE — Ssrf sanitizer, applied at the head of an alias chain — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San03AliasHopSsrfSafe {
  public async Task Run(string input) {
    var a = System.Uri.EscapeDataString(input);
    var b = a;
    var v = b;
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
