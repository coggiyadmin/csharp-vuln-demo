using System.Diagnostics;
public class Prp08SpanConcatCmdi {
  public void Run(string a, string b) {
    var v = a + b;
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
