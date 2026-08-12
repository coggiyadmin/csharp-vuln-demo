using Microsoft.CodeAnalysis.CSharp.Scripting;
public class UnsafeEvalUserTp {
  public async System.Threading.Tasks.Task Run(string code) {
    var full = "return " + code;
    await CSharpScript.EvaluateAsync(full);
  }
}
