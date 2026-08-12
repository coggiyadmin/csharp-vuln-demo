using System; using Microsoft.CodeAnalysis.CSharp.Scripting;
public class IlEnvToEval {
  public async System.Threading.Tasks.Task Run() {
    var code = Environment.GetEnvironmentVariable("CODE") ?? "";
    await CSharpScript.RunAsync(code); // SINK env→eval
  }
}
