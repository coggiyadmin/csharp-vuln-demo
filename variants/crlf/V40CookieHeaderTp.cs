using Microsoft.AspNetCore.Http;
public class V40CookieHeaderTp {
  public void Run(HttpResponse Response, string name) {
    Response.Headers["Set-Cookie"] = "id=" + name; // SINK CRLF header
  }
}
