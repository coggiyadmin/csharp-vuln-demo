// SAFE — Ssrf sanitizer, applied inside a try block — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San10TryCatchSsrfSafe {
  public async Task Run(string input) {
    try {
      var v = System.Uri.EscapeDataString(input);
      await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
    } catch { }
  }
}
