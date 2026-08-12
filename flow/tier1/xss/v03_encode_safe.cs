public class V03EncodeSafe {
  public object Run(string input) {
    return Html.Raw(System.Net.WebUtility.HtmlEncode(input));
  }
}
