using Microsoft.AspNetCore.Mvc;
public class Sk16CsrfTokenSafe : Controller {
  [ValidateAntiForgeryToken]
  public IActionResult Post() => Ok();
}
