using System.Diagnostics;
public class SafeProcessWaitfor {
  public void Run() {
    var p = Process.Start(new ProcessStartInfo("true") { UseShellExecute = false });
    p?.WaitForExit();
  }
}
