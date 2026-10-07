using Microsoft.AspNetCore.Mvc;
public class FakeSanOpenRedirectTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    return new RedirectResult(v); // SINK CWE-601
  }
}
