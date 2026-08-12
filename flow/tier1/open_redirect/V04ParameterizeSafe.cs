using Microsoft.AspNetCore.Mvc;
public class V04ParameterizeSafe {
  public IActionResult Run(string input) {
    _ = input;
  }
}
