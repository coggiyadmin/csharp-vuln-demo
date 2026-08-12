using System.Diagnostics;
public class V30BashCTp {
  public void Run(string arg) {
    var full = "/bin/bash -c " + arg;
    Process.Start(full); // SINK CWE-78
  }
}
