// SAFE — CommandInjection sanitizer, applied at the head of an alias chain — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San03AliasHopCommandInjectionSafe {
  public void Run(string input) {
    var a = Regex.Replace(input, "[^A-Za-z0-9_]", "");
    var b = a;
    var v = b;
    Process.Start("sh -c " + v);
  }
}
