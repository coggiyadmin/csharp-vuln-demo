// SAFE — crlf: closed character allowlist excludes CR and LF
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
public class V02ValidateSafe {
  static HttpResponse Response;
  public void Run(string input) {
    if (!Regex.IsMatch(input, "^[A-Za-z0-9_-]+$"))
      return;
    Response.Headers.Append("X-Trace", input);
  }
}
