using System.Text.RegularExpressions;
public class Sk11RegexTimeoutWrongTp {
  public bool Run(string pattern, string input) => Regex.IsMatch(input, pattern); // SINK
}
