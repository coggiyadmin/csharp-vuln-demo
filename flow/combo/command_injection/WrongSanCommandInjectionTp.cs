using System.Diagnostics;
public class WrongSanCommandInjectionTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var full = "sh -c " + v;
        Process.Start(full); // SINK CWE-78
  }
}
