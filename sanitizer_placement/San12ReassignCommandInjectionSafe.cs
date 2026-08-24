// SAFE — CommandInjection sanitizer, applied by reassigning the same variable — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San12ReassignCommandInjectionSafe {
  public void Run(string input) {
    var v = input;
    v = Regex.Replace(v, "[^A-Za-z0-9_]", "");
    Process.Start("sh -c " + v);
  }
}
