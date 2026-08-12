using System.Diagnostics;
public class San11DelayedEncodeCommandInjectionTp {
  public void Run(string input) {
    var full = "sh -c " + input;
    Process.Start(full); // SINK CWE-78
  }
}
