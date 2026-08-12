using Microsoft.AspNetCore.Http;
public class KestrelHeaderCrlfSafe {
  public void Run(HttpResponse res, string v) {
    var clean = v.Replace("\r", "").Replace("\n", "");
    res.Headers.Append("X-User", clean);
  }
}
