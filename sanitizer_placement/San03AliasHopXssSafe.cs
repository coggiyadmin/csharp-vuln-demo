public class San03AliasHopXssSafe {
  public object Run(string input) {
    var v = System.Web.HttpUtility.HtmlEncode(input);
    return Html.Raw("<div>" + v + "</div>");
  }
}
