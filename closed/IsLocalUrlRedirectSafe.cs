using Microsoft.AspNetCore.Mvc;
// cognium-dev#946 — Url.IsLocalUrl before Redirect stays clean
public class IsLocalUrlRedirectSafe : ControllerBase {
  public IActionResult M(string next) {
    if (Url.IsLocalUrl(next)) { return Redirect(next); }
    return Redirect("/");
  }
}
