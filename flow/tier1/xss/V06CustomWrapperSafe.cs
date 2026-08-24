// SAFE — xss: wrapper encodes on every path
using System.Net;
public class V06CustomWrapperSafe {
  string Sink;
  string ContentType;
  public void Run(string input) {
    Sink = Wrap(input);
  }
  static string Wrap(string raw) {
    return "<div>" + WebUtility.HtmlEncode(raw) + "</div>";
  }
}
