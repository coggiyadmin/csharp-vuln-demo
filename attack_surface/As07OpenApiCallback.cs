using System.Net.Http; using System.Threading.Tasks;
public class As07OpenApiCallback {
  public async Task Callback(string url) {
    await new HttpClient().PostAsync(url, null); // OpenAPI callback SSRF
  }
}
