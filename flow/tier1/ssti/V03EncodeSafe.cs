// SAFE — ssti: value HTML-encoded before it reaches the model
using System.Web;
using System.Net;
public class V03EncodeSafe {
  static string Rendered;
  public void Run(string input) {
    var safe = WebUtility.HtmlEncode(input);
    Rendered = Razor.Parse("Hello @Model.Name", new { Name = safe });
  }
}
