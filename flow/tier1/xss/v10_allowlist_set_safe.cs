public class V10AllowlistSetSafe {
  public object Run(string input) {
    var allow = new[]{"a","b"};
    if (System.Array.IndexOf(allow, input) >= 0) { _ = input; }
  }
}
