using Microsoft.AspNetCore.Mvc;
public class LoopOpenRedirectTp {
  public IActionResult Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    return new RedirectResult(v); // SINK
  }
}
