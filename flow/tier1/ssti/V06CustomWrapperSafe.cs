using System.Web;
public class V06CustomWrapperSafe {
  static string Sanitize(string s) => new string(s.Where(char.IsLetterOrDigit).ToArray());
  public void Run(string input) {
    var v = Sanitize(input);
    return "Hello " + HttpUtility.HtmlEncode(v);
  }
}
