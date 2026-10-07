using Microsoft.AspNetCore.Http;
public class V41LocationHeaderTp {
  public void Run(HttpResponse Response, string url) {
    Response.Headers["Location"] = url; // SINK CRLF/open redirect header
  }
}
