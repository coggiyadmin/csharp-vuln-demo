public class FakeSanSstiTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    return Scriban.Template.Parse(v).Render(); // SINK CWE-1336
  }
}
