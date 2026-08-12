using Microsoft.CodeAnalysis.CSharp.Scripting;
public class FanoutCodeInjectionTp {
  public void Run(string input) {
    var a = input; var b = a;
    var full = "return " + b;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
