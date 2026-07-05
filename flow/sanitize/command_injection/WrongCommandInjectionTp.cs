public class WrongCommandInjectionTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    System.Diagnostics.Process.Start("sh", "-c grep " + v); // SINK CWE-78
  }
}
