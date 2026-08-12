using Microsoft.AspNetCore.Mvc;
public class OopOpenRedirectTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public IActionResult Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    return new RedirectResult(v); // SINK
  }
}
