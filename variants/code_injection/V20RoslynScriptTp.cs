using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V20RoslynScriptTp {
  public async System.Threading.Tasks.Task Run(string expr) {
    var full = "return " + expr;
    await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
