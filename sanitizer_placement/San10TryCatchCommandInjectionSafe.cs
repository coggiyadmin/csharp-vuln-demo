// SAFE — CommandInjection sanitizer, applied inside a try block — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San10TryCatchCommandInjectionSafe {
  public void Run(string input) {
    try {
      var v = Regex.Replace(input, "[^A-Za-z0-9_]", "");
      Process.Start("sh -c " + v);
    } catch { }
  }
}
