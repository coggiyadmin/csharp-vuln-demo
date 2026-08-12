using System.Net.Http;
using System.Threading.Tasks;
public class V05FrameworkNativeSafe {
  public async Task Run(string input) {
    if (new System.Uri(input).Host == "api.internal.example.com") await new HttpClient().GetAsync(input);
  }
}
