using Microsoft.AspNetCore.Http;
public class V01SecureCookieSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions { Secure = true, HttpOnly = true, SameSite = SameSiteMode.Strict });
  }
}
