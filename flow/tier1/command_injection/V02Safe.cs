// SAFE — command_injection: fixed binary plus a closed subcommand allowlist.
using System.Diagnostics;
public class V02Safe {
  public void Run(string input) {
    if (input != "status" && input != "version")
      return;
    var psi = new ProcessStartInfo("/usr/bin/systemctl") { UseShellExecute = false };
    psi.ArgumentList.Add(input);
    Process.Start(psi);
  }
}
