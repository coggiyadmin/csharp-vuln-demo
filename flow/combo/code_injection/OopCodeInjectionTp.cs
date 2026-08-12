using Microsoft.CodeAnalysis.CSharp.Scripting;
public class OopCodeInjectionTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var full = "return " + h.V;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
