using Microsoft.AspNetCore.Http;
public class V50ResponseHeaderTp {
  public void Run(HttpResponse res, string v) => res.Headers["X-User"] = v; // SINK
}
