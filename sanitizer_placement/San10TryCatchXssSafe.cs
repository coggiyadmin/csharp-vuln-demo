public class San10TryCatchXssSafe {
  public object Run(string input) {
    try { return Html.Raw(System.Web.HttpUtility.HtmlEncode(input)); } catch { return Html.Raw(""); }

  }
}
