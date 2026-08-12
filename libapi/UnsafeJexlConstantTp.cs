using Microsoft.CodeAnalysis.CSharp.Scripting;
public class UnsafeJexlConstantTp {
  public async System.Threading.Tasks.Task Run(string expr) {
    await CSharpScript.EvaluateAsync(expr); // SINK dynamic expr
  }
}
