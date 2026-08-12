using System.Diagnostics;
public class AgentToolShellUnscoped {
  public void Shell(string cmd) => Process.Start("/bin/sh", "-c " + cmd);
}
