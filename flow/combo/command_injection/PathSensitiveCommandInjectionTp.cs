using System.Diagnostics;
public class PathSensitiveCommandInjectionTp {
  public void Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var full = "sh -c " + v;
        Process.Start(full); // SINK CWE-78
  }
}
