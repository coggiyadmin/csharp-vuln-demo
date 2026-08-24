// SAFE — CommandInjection sanitizer, applied inside a LINQ projection — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;
public class San09LinqSelectCommandInjectionSafe {
  public void Run(string input) {
    var v = new[] { input }.Select(x => Regex.Replace(x, "[^A-Za-z0-9_]", "")).First();
    Process.Start("sh -c " + v);
  }
}
