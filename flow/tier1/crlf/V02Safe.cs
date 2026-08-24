// SAFE — crlf: reject any value carrying a line break
using Microsoft.AspNetCore.Http;
public class V02Safe {
  static HttpResponse Response;
  public void Run(string input) {
    if (input.Contains('\r') || input.Contains('\n'))
      return;
    Response.Headers.Append("X-Trace", input);
  }
}
