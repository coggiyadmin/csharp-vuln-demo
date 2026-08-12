public class Prp02FieldXss {
  string _m;
  public void Set(string m) { _m = m; }
  public object Run() {
    var s = "<div>" + _m + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
