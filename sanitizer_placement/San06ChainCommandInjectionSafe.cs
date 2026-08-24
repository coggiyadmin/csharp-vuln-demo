// SAFE — CommandInjection sanitizer, applied at the end of a call chain — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San06ChainCommandInjectionSafe {
  public void Run(string input) {
    var v = Regex.Replace(input.Trim().ToLowerInvariant(), "[^A-Za-z0-9_]", "");
    Process.Start("sh -c " + v);
  }
}
