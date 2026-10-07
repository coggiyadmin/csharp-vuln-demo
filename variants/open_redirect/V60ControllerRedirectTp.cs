using Microsoft.AspNetCore.Mvc;
public class V60ControllerRedirectTp : Controller {
  public IActionResult Go([FromQuery] string url) => Redirect(url); // SINK
}
