using System.Text.RegularExpressions;
public class Sk11RegexTimeoutSafe {
  static readonly Regex Re = new(@"^[a-z0-9]+$", RegexOptions.Compiled, System.TimeSpan.FromMilliseconds(50));
  public bool Run(string input) => Re.IsMatch(input);
}
