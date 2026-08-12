using System.Linq;
public class San09LinqSelectXssSafe {
  public object Run(string input) {
    var v = System.Web.HttpUtility.HtmlEncode(new[] { input }.First());
    return Html.Raw("<div>" + v + "</div>");
  }
}
