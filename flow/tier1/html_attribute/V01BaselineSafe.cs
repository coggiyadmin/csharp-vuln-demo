using Microsoft.AspNetCore.Mvc;
using System.Net;
public class V01BaselineSafe : Controller {
  [HttpGet("/link")]
  public ContentResult Link([FromQuery] string url) {
    var e = WebUtility.HtmlEncode(url);
    return Content($"<a href=\"{e}\">click</a>", "text/html");
  }
}
