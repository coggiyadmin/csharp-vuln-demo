using System.Text.RegularExpressions;
public class V50TimeoutNoneTp {
  public bool Run(string pattern, string input) => Regex.IsMatch(input, pattern); // SINK no timeout
}
