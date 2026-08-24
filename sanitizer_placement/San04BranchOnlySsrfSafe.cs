// SAFE — Ssrf sanitizer, applied inside the only branch that reaches the sink — host is a constant; the value is percent-encoded into the query only
using System.Net.Http;
using System.Threading.Tasks;
public class San04BranchOnlySsrfSafe {
  public async Task Run(string input) {
    if (input.Length == 0)
      return;
    var v = System.Uri.EscapeDataString(input);
    await new HttpClient().GetAsync("https://api.internal.example.com/?x=" + v);
  }
}
