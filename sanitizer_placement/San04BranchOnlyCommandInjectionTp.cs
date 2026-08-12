using System.Diagnostics;
public class San04BranchOnlyCommandInjectionTp {
  public void Run(string input) {
    if (input.Length > 0) { /* no real sanitize */ }
    var full = "sh -c " + input;
    Process.Start(full); // SINK CWE-78
  }
}
