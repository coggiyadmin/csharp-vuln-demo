using Microsoft.AspNetCore.Mvc;
public class V09GuardInVariableSafe {
  public IActionResult Run(string input) {
    var ok = input.Length < 64;
    if (ok) { _ = input; }
  }
}
