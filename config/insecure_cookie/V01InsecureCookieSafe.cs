using Microsoft.AspNetCore.Http;
public class V01InsecureCookieSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sid", "x", new CookieOptions { HttpOnly = true, Secure = true });
  }
}
