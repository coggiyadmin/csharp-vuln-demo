using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V10CSharpScriptRunTp {
  public async void Run(string code) {
    var full = "return " + code;
    await CSharpScript.RunAsync(full); // SINK CWE-94
  }
}
