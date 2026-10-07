using Microsoft.AspNetCore.Http;
namespace Demo.Xfile.Crlf;
public static class XfCrlfHelper {
  public static void Write(HttpResponse res, string v) { res.Headers["X-User"] = v; } // SINK
}
