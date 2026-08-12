using Microsoft.CodeAnalysis.CSharp.Scripting;
public class V02Safe {
  public object Run(string input) {
    return 1; // no dynamic eval
  }
}
