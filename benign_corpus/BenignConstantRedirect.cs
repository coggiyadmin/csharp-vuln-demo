using Microsoft.AspNetCore.Mvc;
/** TN — constant redirect. */
public class BenignConstantRedirect : Controller {
  public IActionResult Run() => Redirect("/dashboard");
}
