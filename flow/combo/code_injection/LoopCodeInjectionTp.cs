using Microsoft.CodeAnalysis.CSharp.Scripting;
public class LoopCodeInjectionTp {
  public void Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var full = "return " + acc;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
