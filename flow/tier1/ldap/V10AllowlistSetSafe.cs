using System.DirectoryServices;
public class V10AllowlistSetSafe {
  public void Run(string input) {
    var allow = new[]{"a","b"};
    if (System.Array.IndexOf(allow, input) >= 0) { _ = input; }
  }
}
