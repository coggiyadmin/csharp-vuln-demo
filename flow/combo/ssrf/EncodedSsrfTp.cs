using System.Net.Http;
public class EncodedSsrfTp {
  public async Task Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var u = v + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
