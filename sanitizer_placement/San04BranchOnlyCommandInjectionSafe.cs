using System.Diagnostics;
public class San04BranchOnlyCommandInjectionSafe {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
