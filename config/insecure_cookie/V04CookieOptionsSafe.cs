// SAFE — insecure_cookie: fully scoped cookie — path, domain and lifetime bounded.
using Microsoft.AspNetCore.Http;
public class V04CookieOptionsSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions {
      Secure = true,
      HttpOnly = true,
      SameSite = SameSiteMode.Strict,
      Path = "/app",
      MaxAge = System.TimeSpan.FromMinutes(30)
    });
  }
}
