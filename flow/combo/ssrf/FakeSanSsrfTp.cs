using System.Net.Http;
public class FakeSanSsrfTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    await new HttpClient().GetAsync(v); // SINK CWE-918
  }
}
