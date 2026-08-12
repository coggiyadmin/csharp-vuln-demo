using System.Net.Http;
using System.Threading.Tasks;
public class San07CalleeSsrfSafe {
  static async Task Fetch(string url) {
    if (new System.Uri(url).Host == "api.internal.example.com") await new HttpClient().GetAsync(url);
  }
  public async Task Run(string input) => await Fetch(input);
}
