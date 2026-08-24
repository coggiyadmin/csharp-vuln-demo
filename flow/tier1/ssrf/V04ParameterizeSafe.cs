// SAFE — ssrf: host is fixed; input confined to an escaped query value
using System.Net.Http;
using System.Threading.Tasks;
public class V04ParameterizeSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    var builder = new System.UriBuilder("https://api.internal.example.com/lookup");
    builder.Query = "id=" + System.Uri.EscapeDataString(input);
    await new HttpClient().GetAsync(builder.Uri);
  }
}
