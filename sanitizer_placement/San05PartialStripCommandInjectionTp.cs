using System.Diagnostics;
public class San05PartialStripCommandInjectionTp {
  public void Run(string input) {
    var v = input.Replace("&", ""); // strips & but leaves ; and backticks
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}
