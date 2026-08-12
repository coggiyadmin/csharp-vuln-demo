public class San03AliasHopXssTp {
  public object Run(string input) {
    var a = input;
    var b = a;
    var v = b;
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
