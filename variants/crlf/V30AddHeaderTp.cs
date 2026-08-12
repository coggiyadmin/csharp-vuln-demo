using Microsoft.AspNetCore.Http;
public class V30AddHeaderTp {
  public void Run(HttpResponse res, string v) {
    res.Headers.Append("X-User", v); // SINK CWE-113
  }
}
