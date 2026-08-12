using Microsoft.AspNetCore.Http;
public class V20ResponseHeaderTp {
  public void Run(HttpResponse Response, string v) {
    Response.Headers["X-Trace"] = v; // SINK CWE-113
  }
}
