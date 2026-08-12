using System.Diagnostics;
// CliWrap-shaped: still Process under the hood
public class V20CliWrapTp {
  public void Run(string arg) {
    var full = "git " + arg;
    Process.Start(full); // SINK CWE-78
  }
}
