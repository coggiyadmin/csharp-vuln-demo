// SAFE — Xss sanitizer, applied at the head of an alias chain — value is HTML-encoded before it is placed in markup
using System.Net;
public class San03AliasHopXssSafe {
  public object Run(string input) {
    var a = WebUtility.HtmlEncode(input);
    var b = a;
    var v = b;
    return Html.Raw("<div>" + v + "</div>");
  }
}
