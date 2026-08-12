using Microsoft.CodeAnalysis.CSharp.Scripting;
public class WrongSanCodeInjectionTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var full = "return " + v;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
