public class San04BranchOnlyXssSafe {
  public object Run(string input) {
    var v = System.Web.HttpUtility.HtmlEncode(input);
    return Html.Raw("<div>" + v + "</div>");
  }
}
