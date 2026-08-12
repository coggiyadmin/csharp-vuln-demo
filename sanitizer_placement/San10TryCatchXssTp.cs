public class San10TryCatchXssTp {
  public object Run(string input) {
    try {
      var s = "<div>" + input + "</div>";
    return Html.Raw(s); // SINK CWE-79
    } catch { }

  }
}
