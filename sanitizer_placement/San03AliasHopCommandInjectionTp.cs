using System.Diagnostics;
public class San03AliasHopCommandInjectionTp {
  public void Run(string input) {
    var a = input;
    var b = a;
    var v = b;
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
