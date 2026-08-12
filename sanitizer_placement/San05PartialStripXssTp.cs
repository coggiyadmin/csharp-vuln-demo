public class San05PartialStripXssTp {
  public object Run(string input) {
    var v = input.Replace(";", "");
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
