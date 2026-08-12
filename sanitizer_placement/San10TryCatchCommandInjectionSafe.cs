using System.Diagnostics;
public class San10TryCatchCommandInjectionSafe {
  public void Run(string input) {
    try { Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false }); } catch { }

  }
}
