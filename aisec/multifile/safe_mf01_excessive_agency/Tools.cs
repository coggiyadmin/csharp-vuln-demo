using System.Diagnostics;
public static class Tools {
  static readonly string[] Allow = { "ls", "pwd" };
  public static void Shell(string cmd) {
    if (System.Array.IndexOf(Allow, cmd) < 0) return;
    Process.Start(new ProcessStartInfo(cmd) { UseShellExecute = false });
  }
}
