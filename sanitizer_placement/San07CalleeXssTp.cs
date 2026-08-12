public class San07CalleeXssTp {
  static string Pass(string s) => s;
  public object Run(string input) {
    var v = Pass(input);
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
