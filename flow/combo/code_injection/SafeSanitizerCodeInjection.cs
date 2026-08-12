using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;
public class SafeSanitizerCodeInjection {
  public void Run(string input) {
    _ = input; // sanitized / no sink
  }
}
