using System.Diagnostics;
public class V31CmdExeTp {
  public void Run(string arg) {
    var full = "cmd.exe /c " + arg;
    Process.Start(full); // SINK CWE-78
  }
}
