// SAFE — command_injection combo: allowlist AND argv execution together.
using System.Diagnostics;
using System.Text.RegularExpressions;
public class SafeSanitizerCommandInjection {
  public void Run(string input) {
    if (!Regex.IsMatch(input, "^[A-Za-z0-9_]+$"))
      return;
    var psi = new ProcessStartInfo("grep") { UseShellExecute = false };
    psi.ArgumentList.Add("--");
    psi.ArgumentList.Add(input);
    Process.Start(psi);
  }
}
