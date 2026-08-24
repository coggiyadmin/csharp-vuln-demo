// SAFE — ssrf: request built against a constant base address; input only escapes into the query.
using System.Net.Http;
using System.Threading.Tasks;
public class V02Safe {
  public async Task Run(string input) {
    var builder = new System.UriBuilder("https://api.internal.example.com/lookup");
    builder.Query = "id=" + System.Uri.EscapeDataString(input);
    await new HttpClient().GetAsync(builder.Uri);
  }
}
