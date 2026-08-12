using System.Diagnostics;
public class San06ChainCommandInjectionTp {
  public void Run(string input) {
    var v = input.Trim().ToLowerInvariant();
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
