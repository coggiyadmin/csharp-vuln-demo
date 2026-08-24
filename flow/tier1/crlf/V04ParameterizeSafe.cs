// SAFE — crlf: only a derived integer reaches the header value
using Microsoft.AspNetCore.Http;
public class V04ParameterizeSafe {
  static HttpResponse Response;
  public void Run(string input) {
    Response.Headers.Append("X-Trace", "request");
    Response.Headers.Append("X-Trace-Length", input.Length.ToString());
  }
}
