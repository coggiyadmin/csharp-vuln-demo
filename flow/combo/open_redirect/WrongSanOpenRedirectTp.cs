using Microsoft.AspNetCore.Mvc;
public class WrongSanOpenRedirectTp {
  public IActionResult Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    return new RedirectResult(v); // SINK
  }
}
