// SAFE — CommandInjection sanitizer, applied late, immediately before the sink — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San11DelayedEncodeCommandInjectionSafe {
  public void Run(string input) {
    var t = input;
    var length = t.Length;
    var v = Regex.Replace(t, "[^A-Za-z0-9_]", "");
    Process.Start("sh -c " + v);
  }
}
