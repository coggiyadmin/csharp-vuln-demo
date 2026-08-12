using System.IO;
public class V10AllowlistSetSafe {
  public string Run(string input) {
    var allow = new[]{"a","b"};
    if (System.Array.IndexOf(allow, input) >= 0) { _ = input; }
  }
}
