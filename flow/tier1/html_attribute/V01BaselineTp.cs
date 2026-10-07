using Microsoft.AspNetCore.Mvc;
// Tier-1 html_attribute — user input in HTML attribute without encoding
public class V01BaselineTp : Controller {
  [HttpGet("/link")]
  public ContentResult Link([FromQuery] string url) {
    return Content($"<a href=\"{url}\">click</a>", "text/html"); // SINK attribute XSS
  }
}
