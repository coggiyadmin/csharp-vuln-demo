// SAFE — ssti: closed key set plus a constant template
using System.Web;
using System.Collections.Generic;
public class V07HardeningSafe {
  static string Rendered;
  public void Run(string input) {
    var allowed = new HashSet<string> { "greet", "bye" };
    if (!allowed.Contains(input))
      return;
    Rendered = Razor.Parse("Hello @Model.Name", new { Name = "user" });
  }
}
