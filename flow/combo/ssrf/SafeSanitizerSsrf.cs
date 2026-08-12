using System.Net.Http;
using System.Threading.Tasks;
public class SafeSanitizerSsrf {
  public async System.Threading.Tasks.Task Run(string input) {
    if (new System.Uri(input).Host == "api.internal.example.com") await new HttpClient().GetAsync(input);
  }
}
