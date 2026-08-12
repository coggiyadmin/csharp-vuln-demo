using Microsoft.AspNetCore.Mvc;
public class EncodedOpenRedirectTp {
  public IActionResult Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    return new RedirectResult(v); // SINK
  }
}
