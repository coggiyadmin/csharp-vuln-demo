using Microsoft.AspNetCore.Mvc;
public class Sk07AllowlistRedirectSafe : Controller {
  public IActionResult Run(string next) {
    if (next is not ("/home" or "/dash")) return Redirect("/home");
    return LocalRedirect(next);
  }
}
