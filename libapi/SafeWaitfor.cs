using System.Diagnostics; using System.Threading.Tasks;
public class SafeWaitfor {
  public async Task Run() {
    var p = Process.Start(new ProcessStartInfo("true") { UseShellExecute = false });
    if (p != null) await p.WaitForExitAsync();
  }
}
