using Microsoft.AspNetCore.Mvc;
public class BenignFlow : Controller {
  [HttpGet("/link")]
  public ContentResult Link() => Content("<a href=\"/home\">click</a>", "text/html");
}
