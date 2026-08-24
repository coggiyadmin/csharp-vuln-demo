// SAFE — CommandInjection sanitizer, applied to a truncated copy of the input — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San05PartialStripCommandInjectionSafe {
  public void Run(string input) {
    var t = input.Length > 64 ? input.Substring(0, 64) : input;
    var v = Regex.Replace(t, "[^A-Za-z0-9_]", "");
    Process.Start("sh -c " + v);
  }
}
