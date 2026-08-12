using System.Diagnostics;
public class FanoutCommandInjectionTp {
  public void Run(string input) {
    var a = input; var b = a;
    var full = "sh -c " + b;
        Process.Start(full); // SINK CWE-78
  }
}
