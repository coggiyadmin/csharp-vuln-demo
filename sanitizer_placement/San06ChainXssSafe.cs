public class San06ChainXssSafe {
  public object Run(string input) {
    var v = System.Web.HttpUtility.HtmlEncode(input.Trim());
    return Html.Raw("<div>" + v + "</div>");
  }
}
