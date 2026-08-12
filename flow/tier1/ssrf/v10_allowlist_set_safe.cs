using System.Net.Http;
using System.Threading.Tasks;
public class V10AllowlistSetSafe {
  public async Task Run(string input) {
    var allow = new[]{"a","b"};
    if (System.Array.IndexOf(allow, input) >= 0) { _ = input; }
  }
}
