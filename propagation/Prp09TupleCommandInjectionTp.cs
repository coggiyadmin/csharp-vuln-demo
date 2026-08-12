using System.Diagnostics;
public class Prp09TupleCommandInjectionTp {
  public void Run(string input) {
    var tup = (input, 1);
    var v = tup.Item1;
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
