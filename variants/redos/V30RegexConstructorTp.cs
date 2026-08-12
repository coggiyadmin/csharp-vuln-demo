using System.Text.RegularExpressions;
public class V30RegexConstructorTp {
  public bool Run(string pattern, string input) {
    return new Regex(pattern).IsMatch(input); // SINK CWE-1333
  }
}
