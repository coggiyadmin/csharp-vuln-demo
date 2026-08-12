using Microsoft.AspNetCore.Mvc;
public class V20AllowlistRedirectSafe : Controller {
  public IActionResult Go(string next) {
    if (next is not ("/home" or "/dash")) return Redirect("/home");
    return LocalRedirect(next);
  }
}
