using System.Text.RegularExpressions;
public class SafePatternCompile {
  static readonly Regex Re = new(@"^[a-z]+$", RegexOptions.Compiled, System.TimeSpan.FromMilliseconds(50));
  public bool Run(string s) => Re.IsMatch(s);
}
