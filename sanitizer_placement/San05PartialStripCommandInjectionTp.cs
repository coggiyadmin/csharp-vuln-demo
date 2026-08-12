using System.Diagnostics;
public class San05PartialStripCommandInjectionTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
