using Microsoft.AspNetCore.Http;
public class EncodedCrlfTp {
  public void Run(string input, HttpResponse res) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    res.Headers["X-User"] = v; // SINK
  }
}
