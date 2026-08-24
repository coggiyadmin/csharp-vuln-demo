// SAFE — Ssrf sanitizer, applied inside a LINQ projection — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
public class San09LinqSelectSsrfSafe {
  public async Task Run(string input) {
    var v = new[] { input }.Select(x => System.Uri.EscapeDataString(x)).First();
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
