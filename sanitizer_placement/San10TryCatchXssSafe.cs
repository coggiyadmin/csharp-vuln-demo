// SAFE — Xss sanitizer, applied inside a try block — value is HTML-encoded before it is placed in markup
using System.Net;
public class San10TryCatchXssSafe {
  public object Run(string input) {
    try {
      var v = WebUtility.HtmlEncode(input);
      Html.Raw("<div>" + v + "</div>");
    } catch { }
    return default;
  }
}
