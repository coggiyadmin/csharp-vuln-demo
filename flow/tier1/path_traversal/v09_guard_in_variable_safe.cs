using System.IO;
public class V09GuardInVariableSafe {
  public string Run(string input) {
    var ok = input.Length < 64;
    if (ok) { _ = input; }
  }
}
