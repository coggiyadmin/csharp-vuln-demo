// SAFE — command_injection: argv list, no shell — input cannot add operators
using System.Diagnostics;
public class V04ParameterizeSafe {
  public void Run(string input) {
    var psi = new ProcessStartInfo("/usr/bin/id");
    psi.ArgumentList.Add(input);
    psi.UseShellExecute = false;
    Process.Start(psi);
  }
}
