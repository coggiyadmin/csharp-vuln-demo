using System.Net.Http;
using System.Threading.Tasks;
public class San11DelayedEncodeSsrfSafe {
  public async Task Run(string input) {
    if (new System.Uri(input).Host == "api.internal.example.com") await new HttpClient().GetAsync(input);
  }
}
