// SAFE — insecure_cookie: Secure and HttpOnly both set.
using Microsoft.AspNetCore.Http;
public class V01InsecureCookieSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions {
      Secure = true, HttpOnly = true
    });
  }
}
