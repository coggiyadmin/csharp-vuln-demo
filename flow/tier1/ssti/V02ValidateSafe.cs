// SAFE — ssti: template chosen by key lookup; input is never template text
using System.Web;
using System.Collections.Generic;
public class V02ValidateSafe {
  static string Rendered;
  public void Run(string input) {
    var templates = new Dictionary<string, string> {
      ["greet"] = "Hello @Model.Name",
      ["bye"] = "Goodbye @Model.Name"
    };
    if (!templates.TryGetValue(input, out var tpl))
      return;
    Rendered = Razor.Parse(tpl, new { Name = "user" });
  }
}
