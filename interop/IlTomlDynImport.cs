using System.Diagnostics;
public class IlTomlDynImport {
  // TOML-configured plugin path → Process
  public void Run(string pluginPath) {
    Process.Start("dotnet", pluginPath); // SINK config→exec
  }
}
