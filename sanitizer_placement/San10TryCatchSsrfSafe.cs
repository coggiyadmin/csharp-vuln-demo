using System.Net.Http;
using System.Threading.Tasks;
public class San10TryCatchSsrfSafe {
  public async Task Run(string input) {
    try {
      if (new System.Uri(input).Host == "api.internal.example.com") await new HttpClient().GetAsync(input);
    } catch { }

  }
}
