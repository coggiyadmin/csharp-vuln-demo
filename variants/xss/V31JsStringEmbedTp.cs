public class V31JsStringEmbedTp {
  public object Run(string user) {
    var s = "<script>var x='" + user + "';</script>";
    return Html.Raw(s); // SINK CWE-79
  }
}
