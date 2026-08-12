public class V30TagHelperTp {
  public object Run(string user) {
    var s = "<span>" + user + "</span>";
    return Html.Raw(s); // SINK CWE-79
  }
}
