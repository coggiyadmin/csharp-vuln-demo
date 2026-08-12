using System.Net.Http;
using System.Threading.Tasks;
public class San03AliasHopSsrfSafe {
  public async Task Run(string input) {
    var v = input;
    if (new System.Uri(v).Host == "api.internal.example.com") await new HttpClient().GetAsync(v);
  }
}
