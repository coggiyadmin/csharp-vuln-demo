using System.Xml;
using System.IO;
public class V09GuardInVariableSafe {
  public void Run(string input) {
    var ok = input.Length < 64;
    if (ok) { _ = input; }
  }
}
