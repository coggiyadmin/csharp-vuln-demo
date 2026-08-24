// SAFE — xss combo: attribute-context encoding on top of HTML encoding.
using System.Text.Encodings.Web;
public class SafeSanitizerXss {
  public object Run(string input) {
    var attr = HtmlEncoder.Default.Encode(input);
    var url = UrlEncoder.Default.Encode(input);
    return Html.Raw("<a title=\"" + attr + "\" href=\"/p/" + url + "\">link</a>");
  }
}
