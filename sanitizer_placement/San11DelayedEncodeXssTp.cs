public class San11DelayedEncodeXssTp {
  public object Run(string input) {
    var s = "<div>" + input + "</div>";
    var e = System.Web.HttpUtility.HtmlEncode(s); // too late — already concatenated
    return Html.Raw(s); // SINK uses unsanitized

  }
}
