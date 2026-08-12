using System.Diagnostics;
public class San11DelayedEncodeCommandInjectionSafe {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
