// SAFE — ssti: template text is constant; input arrives as model data
using System.Web;
public class V01BaselineSafe {
  static string Rendered;
  public void Run(string input) {
    var tpl = "Hello @Model.Name";
    Rendered = Razor.Parse(tpl, new { Name = input });
  }
}
