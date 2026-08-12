using System.Diagnostics;
public class NugetScriptCmdiTp {
  public void Run(string script) {
    Process.Start("sh", "-c " + script); // SINK install hook
  }
}
