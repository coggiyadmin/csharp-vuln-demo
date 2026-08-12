using System.Diagnostics;
public class San03AliasHopCommandInjectionSafe {
  public void Run(string input) {
    var v = input;
    Process.Start(new ProcessStartInfo("grep", v) { UseShellExecute = false });
  }
}
