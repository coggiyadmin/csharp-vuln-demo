using Microsoft.CodeAnalysis.CSharp.Scripting;
public class FakeSanCodeInjectionTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    await CSharpScript.EvaluateAsync(v); // SINK CWE-94
  }
}
