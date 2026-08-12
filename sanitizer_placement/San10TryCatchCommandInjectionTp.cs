using System.Diagnostics;
public class San10TryCatchCommandInjectionTp {
  public void Run(string input) {
    try {
      var full = "sh -c " + input;
    Process.Start(full); // SINK CWE-78
    } catch { }

  }
}
