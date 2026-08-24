// SAFE — Xss sanitizer, applied inside the only branch that reaches the sink — value is HTML-encoded before it is placed in markup
using System.Net;
public class San04BranchOnlyXssSafe {
  public object Run(string input) {
    if (input.Length == 0)
      return default;
    var v = WebUtility.HtmlEncode(input);
    return Html.Raw("<div>" + v + "</div>");
  }
}
