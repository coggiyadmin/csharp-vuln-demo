using System; using System.Diagnostics;
public class SafeIlDotenvShell {
  static readonly string[] Allow = { "migrate", "seed" };
  public void Run() {
    var cmd = Environment.GetEnvironmentVariable("START_CMD") ?? "migrate";
    if (System.Array.IndexOf(Allow, cmd) < 0) return;
    Process.Start(new ProcessStartInfo("dotnet", cmd) { UseShellExecute = false });
  }
}
