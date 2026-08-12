public class San05PartialStripXssSafe {
  public object Run(string input) {
    return Html.Raw(System.Web.HttpUtility.HtmlEncode(input));
  }
}
