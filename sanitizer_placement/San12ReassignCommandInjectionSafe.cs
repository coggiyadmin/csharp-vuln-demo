using System.Diagnostics;
public class San12ReassignCommandInjectionSafe {
  public void Run(string input) {
    var v = input;
    Process.Start(new ProcessStartInfo("grep", v) { UseShellExecute = false });
  }
}
