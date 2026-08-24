// SAFE — Xss sanitizer, applied by reassigning the same variable — value is HTML-encoded before it is placed in markup
using System.Net;
public class San12ReassignXssSafe {
  public object Run(string input) {
    var v = input;
    v = WebUtility.HtmlEncode(v);
    return Html.Raw("<div>" + v + "</div>");
  }
}
