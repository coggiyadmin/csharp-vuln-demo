// Fowler god-class smell — one type owns unrelated concerns.
using System.Diagnostics;
using System.Collections.Generic;
public class GodClass {
  readonly List<string> _users = new();
  readonly Dictionary<string, string> _cache = new();
  public void AddUser(string u) => _users.Add(u);
  public string RenderHtml(string name) => "<h1>" + name + "</h1>";
  public string RunShell(string cmd) {
    var p = Process.Start(new ProcessStartInfo("sh", "-c " + cmd) { RedirectStandardOutput = true });
    return p?.StandardOutput.ReadToEnd() ?? "";
  }
  public void SaveDb() { _cache["last"] = "saved"; }
  public string ChargeCard(string pan) => "charged:" + pan;
  public string Ship(string addr) => "ship:" + addr;
}
