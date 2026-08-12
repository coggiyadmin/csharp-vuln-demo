using System.Diagnostics;
/** TN — argv list, no shell. */
public class BenignProcessArgv {
  public void Run(string pattern) {
    Process.Start(new ProcessStartInfo("grep", pattern) { UseShellExecute = false });
  }
}
