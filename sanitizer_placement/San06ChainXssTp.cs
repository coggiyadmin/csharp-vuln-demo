public class San06ChainXssTp {
  public object Run(string input) {
    var v = input.Trim().ToLowerInvariant();
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
