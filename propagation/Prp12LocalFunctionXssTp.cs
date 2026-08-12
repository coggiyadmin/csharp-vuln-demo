public class Prp12LocalFunctionXssTp {
  public object Run(string input) {
    string Wrap(string s) => s;
    var v = Wrap(input);
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
