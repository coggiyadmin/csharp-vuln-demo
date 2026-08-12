using Microsoft.CodeAnalysis.CSharp.Scripting;
public class SafeExprConstant {
  public async System.Threading.Tasks.Task<int> Run() =>
    await CSharpScript.EvaluateAsync<int>("1+1");
}
