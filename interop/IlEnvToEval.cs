using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;
// cognium-dev #277 — Environment.GetEnvironmentVariable not modeled as taint source
// Expect: code_injection. Observed: FN.
public class IlEnvToEval {
  public async System.Threading.Tasks.Task Run() {
    var code = Environment.GetEnvironmentVariable("CODE") ?? ""; // SOURCE env
    await CSharpScript.RunAsync(code); // SINK env→eval
  }
}
