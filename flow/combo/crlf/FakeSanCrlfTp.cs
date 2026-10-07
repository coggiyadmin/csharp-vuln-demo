using Microsoft.AspNetCore.Http;
public class FakeSanCrlfTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input, HttpResponse res) {
    var v = Sanitize(input); // fake sanitizer — identity
    res.Headers["X-User"] = v; // SINK CWE-113
  }
}
