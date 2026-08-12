using Microsoft.AspNetCore.Mvc;
public class V30RedirectPreserveMethodTp : Controller {
  public IActionResult Run(string next) => RedirectPreserveMethod(next); // SINK CWE-601
}
