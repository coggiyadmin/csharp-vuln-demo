using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V30ScriptEngineTp {
  public async System.Threading.Tasks.Task Run(string code) {
    await CSharpScript.RunAsync(code); // SINK CWE-94
  }
}
