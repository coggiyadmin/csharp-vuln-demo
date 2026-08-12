using System.Diagnostics;
public class Prp12LocalFunctionCommandInjectionTp {
  public void Run(string input) {
    string Wrap(string s) => s;
    var v = Wrap(input);
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
