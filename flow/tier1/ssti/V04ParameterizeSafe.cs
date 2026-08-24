// SAFE — ssti: input bound as a model property, never concatenated into the template
using System.Web;
public class V04ParameterizeSafe {
  static string Rendered;
  public void Run(string input) {
    var model = new { Name = input, Role = "guest" };
    Rendered = Razor.Parse("Hello @Model.Name (@Model.Role)", model);
  }
}
