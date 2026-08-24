// SAFE — xss: encode before composing markup
using System.Net;
public class V04ParameterizeSafe {
  string Sink;
  string ContentType;
  public void Run(string input) {
    var safe = WebUtility.HtmlEncode(input);
    Render("<div>" + safe + "</div>");
  }
  void Render(string html) { Sink = html;
  }
}
