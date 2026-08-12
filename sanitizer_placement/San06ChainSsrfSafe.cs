using System.Net.Http;
using System.Threading.Tasks;
public class San06ChainSsrfSafe {
  public async Task Run(string input) {
    var v = input.Trim();
    if (new System.Uri(v).Host == "api.internal.example.com") await new HttpClient().GetAsync(v);
  }
}
