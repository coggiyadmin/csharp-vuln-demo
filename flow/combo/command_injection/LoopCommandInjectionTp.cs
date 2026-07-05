public class LoopCommandInjectionTp {
  public void Run(string q) {
    var acc = "";
    foreach (var ch in q) acc += ch; // loop-carried
    System.Diagnostics.Process.Start("sh", "-c grep " + acc); // SINK CWE-78
  }
}
