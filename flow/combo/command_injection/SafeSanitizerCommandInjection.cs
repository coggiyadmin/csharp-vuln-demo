using System.Diagnostics;
public class SafeSanitizerCommandInjection {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
