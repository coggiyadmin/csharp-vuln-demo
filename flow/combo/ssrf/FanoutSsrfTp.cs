using System.Net.Http;
public class FanoutSsrfTp {
  public async Task Run(string input) {
    var a = input; var b = a;
    var u = b + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
