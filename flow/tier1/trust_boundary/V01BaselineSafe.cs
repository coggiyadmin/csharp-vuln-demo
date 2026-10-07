using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
public class V01BaselineSafe : Controller {
  [HttpGet("/role")]
  public IActionResult Role([FromQuery] string role) {
    var allowed = role is "user" or "guest" ? role : "guest";
    HttpContext.Session.SetString("role", allowed);
    return Ok("ok");
  }
}
