public class San07CalleeXssSafe {
  static object Render(string msg) => Html.Raw(System.Web.HttpUtility.HtmlEncode(msg));
  public object Run(string input) => Render(input);
}
