// SAFE — Xss sanitizer, applied late, immediately before the sink — value is HTML-encoded before it is placed in markup
using System.Net;
public class San11DelayedEncodeXssSafe {
  public object Run(string input) {
    var t = input;
    var length = t.Length;
    var v = WebUtility.HtmlEncode(t);
    return Html.Raw("<div>" + v + "</div>");
  }
}
