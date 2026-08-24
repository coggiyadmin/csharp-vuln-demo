// SAFE — interop: argv list on ProcessStartInfo, no shell involved.
using System.Diagnostics;
public class SafeIlProcessArgv {
  public void Run(string arg) {
    var psi = new ProcessStartInfo("/usr/bin/grep") { UseShellExecute = false };
    psi.ArgumentList.Add("--");
    psi.ArgumentList.Add(arg);
    Process.Start(psi);
  }
}
