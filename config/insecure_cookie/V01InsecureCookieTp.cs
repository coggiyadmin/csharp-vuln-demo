using Microsoft.AspNetCore.Http;
public class V01InsecureCookieTp {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions { Secure = false, HttpOnly = false }); // SINK CWE-614
  }
}
