// SAFE — Xss sanitizer, applied at the end of a call chain — value is HTML-encoded before it is placed in markup
using System.Net;
public class San06ChainXssSafe {
  public object Run(string input) {
    var v = WebUtility.HtmlEncode(input.Trim().ToLowerInvariant());
    return Html.Raw("<div>" + v + "</div>");
  }
}
