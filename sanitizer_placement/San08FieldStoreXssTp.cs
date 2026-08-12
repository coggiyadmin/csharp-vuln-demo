public class San08FieldStoreXssTp {
  string _v;
  public void Set(string input) { _v = input; }
  public object Run() {
    var s = "<div>" + _v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
