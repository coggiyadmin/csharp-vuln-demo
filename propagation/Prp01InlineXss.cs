public class Prp01InlineXss {
  public object Run(string msg) {
    var s = "<div>" + msg + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
