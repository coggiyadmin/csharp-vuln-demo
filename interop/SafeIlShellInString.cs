// SAFE — interop: the shell string is a constant; input is passed through the environment.
using System.Diagnostics;
public class SafeIlShellInString {
  public void Run(string arg) {
    var psi = new ProcessStartInfo("/bin/sh") { UseShellExecute = false };
    psi.ArgumentList.Add("-c");
    psi.ArgumentList.Add("printf %s \"$TARGET\"");
    psi.Environment["TARGET"] = arg;
    Process.Start(psi);
  }
}
