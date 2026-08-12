using System.Diagnostics;
// IL — managed → shell process boundary (string form)
public class IlProcessSh {
  public void Run(string arg) {
    var full = "/bin/sh -c " + arg;
    Process.Start(full); // SINK CWE-78
  }
}
