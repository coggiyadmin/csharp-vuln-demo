// SAFE — command_injection: framework argv API rather than a command string
using System.Diagnostics;
public class V05FrameworkNativeSafe {
  public void Run(string input) {
    var psi = new ProcessStartInfo { FileName = "/usr/bin/id", UseShellExecute = false };
    psi.ArgumentList.Add(input);
    using var p = Process.Start(psi);
    p.WaitForExit();
  }
}
