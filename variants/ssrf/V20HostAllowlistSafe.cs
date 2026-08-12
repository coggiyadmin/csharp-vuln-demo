using System.Net.Http;
public class V20HostAllowlistSafe {
  public async System.Threading.Tasks.Task Run(string url) {
    if (new System.Uri(url).Host != "api.internal.example.com") return;
    await new HttpClient().GetAsync(url);
  }
}
