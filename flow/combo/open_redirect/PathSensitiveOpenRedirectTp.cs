using Microsoft.AspNetCore.Mvc;
public class PathSensitiveOpenRedirectTp {
  public IActionResult Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    return new RedirectResult(v); // SINK
  }
}
