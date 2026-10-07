using System.IO;
public class FakeSanPathTraversalTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    File.ReadAllText("/data/" + v); // SINK CWE-22
  }
}
