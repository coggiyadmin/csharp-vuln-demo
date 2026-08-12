using System.Diagnostics;
public class LoopCommandInjectionTp {
  public void Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var full = "sh -c " + acc;
        Process.Start(full); // SINK CWE-78
  }
}
