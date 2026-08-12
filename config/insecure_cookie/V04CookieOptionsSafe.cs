using Microsoft.AspNetCore.Http;
public class V04CookieOptionsSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sid", "x", new CookieOptions { HttpOnly = true, Secure = true });
  }
}
