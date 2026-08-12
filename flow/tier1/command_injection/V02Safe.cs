using System.Diagnostics;
public class V02Safe {
  public void Run(string input) {
    Process.Start(new ProcessStartInfo("grep", input) { UseShellExecute = false });
  }
}
