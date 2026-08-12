using System.Diagnostics;
public class V01BaselineSafe {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
