using System.Diagnostics;
public class FakeSanCommandInjectionTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    Process.Start("sh -c " + v); // SINK CWE-78
  }
}
