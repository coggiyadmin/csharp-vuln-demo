using System.Diagnostics;
public class V50CliWrapTp {
  // CliWrap-shaped: shell string
  public void Run(string arg) {
    Process.Start("/bin/sh", "-c " + arg);
  }
}
