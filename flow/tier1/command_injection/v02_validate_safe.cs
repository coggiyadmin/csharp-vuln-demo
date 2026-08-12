using System.Diagnostics;
public class V02ValidateSafe {
  public void Run(string input) {
    if (input.IndexOfAny(new[]{';','|'})>=0) return;
    Process.Start(new ProcessStartInfo("grep", input){UseShellExecute=false});
  }
}
