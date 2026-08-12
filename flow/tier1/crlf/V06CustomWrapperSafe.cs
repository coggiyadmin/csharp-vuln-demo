using Microsoft.AspNetCore.Http;
public class V06CustomWrapperSafe {
  static string Sanitize(string s) => new string(s.Where(char.IsLetterOrDigit).ToArray());
  public void Run(string input) {
    var v = Sanitize(input);
    if (v.All(c => char.IsLetterOrDigit(c) || c == '_')) Response.Headers.Add("X-Trace", v);
  }
}
