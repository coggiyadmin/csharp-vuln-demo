using System.Diagnostics;
public class OopCommandInjectionTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var full = "sh -c " + h.V;
        Process.Start(full); // SINK CWE-78
  }
}
