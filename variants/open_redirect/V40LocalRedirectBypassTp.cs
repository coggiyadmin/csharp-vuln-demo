using Microsoft.AspNetCore.Mvc;
public class V40LocalRedirectBypassTp : Controller {
  public IActionResult Run(string next) => LocalRedirect("//evil.example/" + next); // SINK
}
