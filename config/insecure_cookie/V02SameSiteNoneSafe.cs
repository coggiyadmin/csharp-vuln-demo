using Microsoft.AspNetCore.Http;
public class V02SameSiteNoneSafe {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sid", "x", new CookieOptions { HttpOnly = true, Secure = true });
  }
}
