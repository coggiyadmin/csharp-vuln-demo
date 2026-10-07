using Microsoft.AspNetCore.Mvc;
public class V03Benign : Controller {
  [HttpGet("/link")]
  public ContentResult Link() => Content("<a href=\"/home\">click</a>", "text/html");
}
