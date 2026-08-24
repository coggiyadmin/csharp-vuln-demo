// SAFE — insecure_cookie: session cookie with no persistent expiry.
using Microsoft.AspNetCore.Http;
public class V03SessionCookieSafe {
  public void Run(HttpResponse res) {
    var options = new CookieOptions { Secure = true, HttpOnly = true, SameSite = SameSiteMode.Lax };
    options.Expires = null;
    res.Cookies.Append("sess", "abc", options);
  }
}
