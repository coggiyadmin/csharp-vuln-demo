using System.Diagnostics;
public class NugetScriptCmdiSafe {
  public void Run(string script) {
    Process.Start(new ProcessStartInfo("dotnet", "restore") { UseShellExecute = false });
  }
}
