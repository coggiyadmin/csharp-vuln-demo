using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var full = "return " + v;
            await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
