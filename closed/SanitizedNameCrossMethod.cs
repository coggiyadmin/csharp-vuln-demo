using System.Web;
// cognium-dev#579 — sanitizing `s` in one method must not silence another method's `s`
public class SanitizedNameCrossMethod {
  public void Safe(string s) {
    var encoded = HttpUtility.HtmlEncode(s);
    HttpContext.Current.Response.Write(encoded);
  }
  public void Bad(string s) {
    HttpContext.Current.Response.Write(s); // SINK CWE-79
  }
}
