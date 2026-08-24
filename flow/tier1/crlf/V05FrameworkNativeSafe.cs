// SAFE — crlf: typed header property plus an encoded value
using Microsoft.AspNetCore.Http;
public class V05FrameworkNativeSafe {
  static HttpResponse Response;
  public void Run(string input) {
    Response.Headers.CacheControl = "no-store";
    Response.Headers.Append("X-Trace", System.Uri.EscapeDataString(input));
  }
}
