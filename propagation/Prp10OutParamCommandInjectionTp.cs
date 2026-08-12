using System.Diagnostics;
public class Prp10OutParamCommandInjectionTp {
  static void Box(string i, out string o) { o = i; }
  public void Run(string input) {
    Box(input, out var v);
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
