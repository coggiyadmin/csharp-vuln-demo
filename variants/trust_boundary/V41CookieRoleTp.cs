using Microsoft.AspNetCore.Http;
public class V41CookieRoleTp {
  public void Run(HttpResponse resp, string role) {
    resp.Cookies.Append("role", role); // SINK trusted cookie
  }
}
