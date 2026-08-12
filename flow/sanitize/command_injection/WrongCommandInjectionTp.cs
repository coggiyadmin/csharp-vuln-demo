using System.Diagnostics;
public class WrongCommandInjectionTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    var full = "sh -c " + v;
        Process.Start(full); // SINK CWE-78
  }
}
