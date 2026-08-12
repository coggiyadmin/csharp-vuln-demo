using System.Text.RegularExpressions;
public class V20RegexTimeoutSafe {
  static readonly Regex Re = new(@"^[a-z0-9]+$", RegexOptions.Compiled, System.TimeSpan.FromMilliseconds(100));
  public bool Run(string input) => Re.IsMatch(input);
}
