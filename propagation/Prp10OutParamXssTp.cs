public class Prp10OutParamXssTp {
  static void Box(string i, out string o) { o = i; }
  public object Run(string input) {
    Box(input, out var v);
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
