using Microsoft.AspNetCore.Mvc;
public class FanoutOpenRedirectTp {
  public IActionResult Run(string input) {
    var a = input; var b = a; var v = b + b;
    return new RedirectResult(v); // SINK
  }
}
