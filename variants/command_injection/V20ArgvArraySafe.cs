using System.Diagnostics;
public class V20ArgvArraySafe {
  public void Run(string arg) {
    Process.Start(new ProcessStartInfo("git", arg) { UseShellExecute = false });
  }
}
