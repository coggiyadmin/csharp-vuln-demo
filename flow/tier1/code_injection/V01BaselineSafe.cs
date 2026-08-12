using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V01BaselineSafe {
  public object Run(string input) {
    return 1; // no dynamic eval
  }
}
