using System.Diagnostics;
public class EncodedCommandInjectionTp {
  public void Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var full = "sh -c " + v;
        Process.Start(full); // SINK CWE-78
  }
}
