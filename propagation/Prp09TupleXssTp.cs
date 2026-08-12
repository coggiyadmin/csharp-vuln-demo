public class Prp09TupleXssTp {
  public object Run(string input) {
    var tup = (input, 1);
    var v = tup.Item1;
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
