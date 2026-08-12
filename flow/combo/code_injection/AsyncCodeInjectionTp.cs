using Microsoft.CodeAnalysis.CSharp.Scripting;
public class AsyncCodeInjectionTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var full = "return " + v;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
