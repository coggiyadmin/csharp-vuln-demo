// SAFE — Xss sanitizer, applied to a truncated copy of the input — value is HTML-encoded before it is placed in markup
using System.Net;
public class San05PartialStripXssSafe {
  public object Run(string input) {
    var t = input.Length > 64 ? input.Substring(0, 64) : input;
    var v = WebUtility.HtmlEncode(t);
    return Html.Raw("<div>" + v + "</div>");
  }
}
