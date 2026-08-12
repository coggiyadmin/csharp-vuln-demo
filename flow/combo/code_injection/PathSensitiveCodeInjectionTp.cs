using Microsoft.CodeAnalysis.CSharp.Scripting;
public class PathSensitiveCodeInjectionTp {
  public void Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var full = "return " + v;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
