using System.Diagnostics;
public class San12ReassignCommandInjectionTp {
  public void Run(string input) {
    var v = "safe";
    v = input; // reassign drops sanitize
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
