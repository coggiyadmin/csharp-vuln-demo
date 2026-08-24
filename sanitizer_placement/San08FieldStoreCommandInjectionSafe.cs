// SAFE — CommandInjection sanitizer, applied before the value is stored in a field — only [A-Za-z0-9_] survives, so no shell metacharacter can reach the command
using System.Diagnostics;
using System.Text.RegularExpressions;
public class San08FieldStoreCommandInjectionSafe {
  string _v;
  public void Set(string input) { _v = Regex.Replace(input, "[^A-Za-z0-9_]", ""); }
  public void Run() {
    Process.Start("sh -c " + _v);
  }
}
