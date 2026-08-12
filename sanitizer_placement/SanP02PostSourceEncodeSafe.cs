using System.Web;
public class SanP02PostSourceEncodeSafe {
  public object Run(string msg) {
    var v = HttpUtility.HtmlEncode(msg); // encode at source
    return Html.Raw("<div>" + v + "</div>");
  }
}
