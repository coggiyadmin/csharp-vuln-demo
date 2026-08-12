public class V02ValidateSafe {
  public object Run(string input) {
    if (input.Contains("<")) return Html.Raw("");
    return Html.Raw(System.Net.WebUtility.HtmlEncode(input));
  }
}
