// SAFE — crlf: strip line breaks and bound the length
using Microsoft.AspNetCore.Http;
public class V07HardeningSafe {
  static HttpResponse Response;
  public void Run(string input) {
    var safe = input.Replace("\r", "").Replace("\n", "");
    if (safe.Length > 128)
      safe = safe.Substring(0, 128);
    Response.Headers.Append("X-Trace", safe);
  }
}
