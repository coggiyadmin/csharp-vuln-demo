public class SafeSanitizerXss {
  public object Run(string input) {
    return Html.Raw(System.Net.WebUtility.HtmlEncode(input));
  }
}
