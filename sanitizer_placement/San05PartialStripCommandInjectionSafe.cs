using System.Diagnostics;
public class San05PartialStripCommandInjectionSafe {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
