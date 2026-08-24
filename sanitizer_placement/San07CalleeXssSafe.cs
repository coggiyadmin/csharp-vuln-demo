// SAFE — Xss sanitizer, applied inside a helper the caller delegates to — value is HTML-encoded before it is placed in markup
using System.Net;
public class San07CalleeXssSafe {
  static string Clean(string x) { return WebUtility.HtmlEncode(x); }
  public object Run(string input) {
    var v = Clean(input);
    return Html.Raw("<div>" + v + "</div>");
  }
}
