using Microsoft.AspNetCore.Http;
public class KestrelHeaderCrlfTp {
  public void Run(HttpResponse res, string v) => res.Headers.Append("X-User", v); // SINK
}
