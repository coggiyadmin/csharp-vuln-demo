public class San11DelayedEncodeXssSafe {
  public object Run(string input) {
    return Html.Raw(System.Web.HttpUtility.HtmlEncode(input));
  }
}
