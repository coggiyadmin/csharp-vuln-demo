// SAFE — Xss sanitizer, applied before the value is stored in a field — value is HTML-encoded before it is placed in markup
using System.Net;
public class San08FieldStoreXssSafe {
  string _v;
  public void Set(string input) { _v = WebUtility.HtmlEncode(input); }
  public object Run() {
    return Html.Raw("<div>" + _v + "</div>");
  }
}
