using System.IO;
public class OopPathTraversalTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var full = "/data/" + h.V;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
