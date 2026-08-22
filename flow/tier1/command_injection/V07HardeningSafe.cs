// SAFE — command_injection: fixed binary + closed allowlist of subcommands
using System.Diagnostics;
public class V07HardeningSafe {
  public void Run(string input) {
    if (input != "status" && input != "version")
      return;
    var psi = new ProcessStartInfo("/usr/bin/systemctl") { UseShellExecute = false };
    psi.ArgumentList.Add(input);
    Process.Start(psi);
  }
}
