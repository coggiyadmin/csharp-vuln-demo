// SAFE — crlf: percent-encoding makes a line break unrepresentable
using Microsoft.AspNetCore.Http;
public class V03EncodeSafe {
  static HttpResponse Response;
  public void Run(string input) {
    var safe = System.Uri.EscapeDataString(input);
    Response.Headers.Append("X-Trace", safe);
  }
}
