using System.Net.Http;
public class WrongSsrfTp {
  public async Task Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    var u = v + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
