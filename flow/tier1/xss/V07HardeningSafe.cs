// SAFE — xss: non-HTML content type plus encoding
using System.Net;
public class V07HardeningSafe {
  string Sink;
  string ContentType;
  public void Run(string input) {
    ContentType = "text/plain; charset=utf-8";
    Sink = WebUtility.HtmlEncode(input);
  }
}
