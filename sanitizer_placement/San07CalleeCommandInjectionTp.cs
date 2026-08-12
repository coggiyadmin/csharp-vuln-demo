using System.Diagnostics;
public class San07CalleeCommandInjectionTp {
  static string Pass(string s) => s;
  public void Run(string input) {
    var v = Pass(input);
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
