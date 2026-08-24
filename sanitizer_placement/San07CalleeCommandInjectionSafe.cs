// SAFE — CommandInjection sanitizer, applied inside a helper the caller delegates to — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San07CalleeCommandInjectionSafe {
  static string Clean(string x) { return Regex.Replace(x, "[^A-Za-z0-9_]", ""); }
  public void Run(string input) {
    var v = Clean(input);
    Process.Start("sh -c " + v);
  }
}
