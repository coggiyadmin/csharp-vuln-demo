// SAFE — ssti: a second constant template — input never joins the template text
using System.Web;
public class V02Safe {
  static string Rendered;
  public void Run(string input) {
    var tpl = "Welcome back, @Model.User";
    Rendered = Razor.Parse(tpl, new { User = input });
  }
}
