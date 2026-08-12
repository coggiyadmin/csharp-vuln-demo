using System.Net.Http;
public class WrongSanSsrfTp {
  public async Task Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var u = v + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}
