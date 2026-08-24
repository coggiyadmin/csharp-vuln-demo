// SAFE — Ssrf sanitizer, applied inside a helper the caller delegates to — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San07CalleeSsrfSafe {
  static string Clean(string x) { return System.Uri.EscapeDataString(x); }
  public async Task Run(string input) {
    var v = Clean(input);
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
