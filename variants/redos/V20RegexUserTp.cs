using System.Text.RegularExpressions;
public class V20RegexUserTp {
  public bool Run(string pattern, string input) =>
    Regex.IsMatch(input, pattern); // SINK CWE-1333 user-controlled pattern
}
