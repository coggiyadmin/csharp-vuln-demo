using Microsoft.AspNetCore.Mvc;
public class V20LocalRedirectTp : Controller {
  public IActionResult Go(string next) => LocalRedirect(next); // SINK CWE-601
}
