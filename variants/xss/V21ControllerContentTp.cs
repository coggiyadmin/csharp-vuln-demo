using Microsoft.AspNetCore.Mvc;
public class V21ControllerContentTp : Controller {
  [HttpGet]
  public ContentResult Get(string msg) {
    var s = "<div>" + msg + "</div>";
    return Content(s, "text/html"); // SINK CWE-79
  }
}
