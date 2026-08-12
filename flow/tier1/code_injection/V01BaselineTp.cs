using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V01BaselineTp {
  public void Run(string input) {
    var full = "return " + input;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
