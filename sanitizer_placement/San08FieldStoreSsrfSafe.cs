// SAFE — Ssrf sanitizer, applied before the value is stored in a field — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San08FieldStoreSsrfSafe {
  string _v;
  public void Set(string input) { _v = System.Uri.EscapeDataString(input); }
  public async Task Run() {
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + _v);
  }
}
