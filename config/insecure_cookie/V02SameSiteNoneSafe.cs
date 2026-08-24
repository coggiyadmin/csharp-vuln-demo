// SAFE — insecure_cookie: SameSite=Strict rather than None.
using Microsoft.AspNetCore.Http;
public class V02SameSiteNoneSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions {
      Secure = true, HttpOnly = true, SameSite = SameSiteMode.Strict
    });
  }
}
