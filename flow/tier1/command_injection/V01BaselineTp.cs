using System.Diagnostics;
public class V01BaselineTp {
  public void Run(string input) {
    var full = "sh -c " + input;
        Process.Start(full); // SINK CWE-78
  }
}
