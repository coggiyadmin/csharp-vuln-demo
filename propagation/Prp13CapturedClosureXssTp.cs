public class Prp13CapturedClosureXssTp {
  public object Run(string input) {
    System.Func<string> get = () => input;
    var v = get();
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
