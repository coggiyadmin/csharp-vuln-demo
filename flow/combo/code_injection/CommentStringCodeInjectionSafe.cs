using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;
public class CommentStringCodeInjectionSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    // would be CSharpScript.RunAsync(input)
    await CSharpScript.RunAsync("1+1");
  }
}
