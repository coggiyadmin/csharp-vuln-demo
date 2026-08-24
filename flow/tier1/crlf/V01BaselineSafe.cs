// SAFE — crlf: CR and LF removed before the value reaches a header
using Microsoft.AspNetCore.Http;
public class V01BaselineSafe {
  static HttpResponse Response;
  public void Run(string input) {
    var safe = input.Replace("\r", "").Replace("\n", "");
    Response.Headers.Append("X-Trace", safe);
  }
}
