// SAFE — CommandInjection sanitizer, applied inside the only branch that reaches the sink — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San04BranchOnlyCommandInjectionSafe {
  public void Run(string input) {
    if (input.Length == 0)
      return;
    var v = Regex.Replace(input, "[^A-Za-z0-9_]", "");
    Process.Start("sh -c " + v);
  }
}
