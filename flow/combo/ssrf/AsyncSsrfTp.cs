using System.Net.Http;
public class AsyncSsrfTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var u = v + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
