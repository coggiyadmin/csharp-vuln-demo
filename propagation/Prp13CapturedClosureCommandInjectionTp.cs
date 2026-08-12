using System.Diagnostics;
public class Prp13CapturedClosureCommandInjectionTp {
  public void Run(string input) {
    System.Func<string> get = () => input;
    var v = get();
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
