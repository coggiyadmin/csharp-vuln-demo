public class San04BranchOnlyXssTp {
  public object Run(string input) {
    if (input.Length > 0) { /* no real sanitize */ }
    var s = "<div>" + input + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}
