using Microsoft.AspNetCore.Http;
public class V02SameSiteNoneTp {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sess", "abc", new CookieOptions {
      Secure = false, HttpOnly = false, SameSite = SameSiteMode.None
    }); // SINK CWE-614
  }
}
