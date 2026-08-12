using System.Net.Http;
using System.Threading.Tasks;
public class V09GuardInVariableSafe {
  public async Task Run(string input) {
    var ok = new System.Uri(input).Host == "api.internal.example.com";
    if (ok) await new HttpClient().GetAsync(input);
  }
}
