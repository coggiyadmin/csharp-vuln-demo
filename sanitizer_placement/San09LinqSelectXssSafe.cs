// SAFE — Xss sanitizer, applied inside a LINQ projection — value is HTML-encoded before it is placed in markup
using System.Net;
using System.Linq;
public class San09LinqSelectXssSafe {
  public object Run(string input) {
    var v = new[] { input }.Select(x => WebUtility.HtmlEncode(x)).First();
    return Html.Raw("<div>" + v + "</div>");
  }
}
