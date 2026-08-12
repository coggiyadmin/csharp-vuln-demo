using Microsoft.CodeAnalysis.CSharp.Scripting;
public class EncodedCodeInjectionTp {
  public void Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var full = "return " + v;
        await CSharpScript.EvaluateAsync(full); // SINK CWE-94
  }
}
