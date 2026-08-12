using Microsoft.AspNetCore.Http;
public class V04CookieOptionsTp {
  public void Run(HttpResponse res) {
    res.Cookies.Append("sid", "x", new CookieOptions { HttpOnly = false, Secure = false }); // SINK
  }
}
