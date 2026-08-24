// SAFE — ssti: precompiled template executed with a model — no runtime compilation of input
using System.Web;
public class V05FrameworkNativeSafe {
  static string Rendered;
  static readonly string Compiled = Razor.Compile("Hello @Model.Name");
  public void Run(string input) {
    Rendered = Razor.Run(Compiled, new { Name = input });
  }
}
