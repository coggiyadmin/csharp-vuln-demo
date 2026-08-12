using System.Diagnostics;
public class IlShellInString {
  public void Run(string user) {
    var script = "echo hello; " + user; // shell metachar in string
    var full = "/bin/sh -c " + script;
    Process.Start(full); // SINK CWE-78
  }
}
