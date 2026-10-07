using Microsoft.CodeAnalysis.CSharp.Scripting;
namespace Demo.Xfile.Codeinj;
public static class XfCodeHelper {
  public static System.Threading.Tasks.Task Eval(string code) =>
    CSharpScript.EvaluateAsync(code); // SINK
}
