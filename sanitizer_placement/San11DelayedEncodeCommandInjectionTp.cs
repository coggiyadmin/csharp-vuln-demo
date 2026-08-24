using System.Diagnostics;
using System.Text.RegularExpressions;
public class San11DelayedEncodeCommandInjectionTp {
  public void Run(string input) {
    var full = "sh -c " + input;
    Process.Start(full); // SINK CWE-78 — encoding below happens too late
    var encoded = Regex.Replace(input, "[^A-Za-z0-9_]", "");
    System.Console.WriteLine(encoded);
  }
}
