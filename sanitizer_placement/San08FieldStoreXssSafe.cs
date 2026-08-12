public class San08FieldStoreXssSafe {
  string _v;
  public void Set(string input) { _v = System.Web.HttpUtility.HtmlEncode(input); }
  public object Run() => Html.Raw("<div>" + _v + "</div>");
}
