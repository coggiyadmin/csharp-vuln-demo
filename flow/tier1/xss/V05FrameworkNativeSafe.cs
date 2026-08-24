// SAFE — xss: framework HtmlEncoder
using System.Text.Encodings.Web;
public class V05FrameworkNativeSafe {
  string Sink;
  string ContentType;
  public void Run(string input) {
    var safe = HtmlEncoder.Default.Encode(input);
    Sink = "<div>" + safe + "</div>";
  }
}
