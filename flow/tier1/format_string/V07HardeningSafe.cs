// SAFE — format_string: invariant culture plus a literal format
using System.Globalization;
public class V07HardeningSafe {
  static string Message;
  public void Run(string input) {
    Message = string.Format(CultureInfo.InvariantCulture, "value: {0}", input);
  }
}
