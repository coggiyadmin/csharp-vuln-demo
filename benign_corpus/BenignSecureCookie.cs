using Microsoft.AspNetCore.Http;
/** TN — Secure + HttpOnly cookie. */
public class BenignSecureCookie {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions { Secure = true, HttpOnly = true });
  }
}
