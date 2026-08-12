public class San12ReassignXssTp {
  public object Run(string input) {
    var v = "safe";
    v = input; // reassign drops sanitize
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
