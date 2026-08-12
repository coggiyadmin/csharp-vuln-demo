using Microsoft.AspNetCore.Mvc;
public class SafeSanitizerOpenRedirect {
  public IActionResult Run(string input) {
    if (input is not ("/home" or "/dash")) return new RedirectResult("/home");
    return new LocalRedirectResult(input);
  }
}
