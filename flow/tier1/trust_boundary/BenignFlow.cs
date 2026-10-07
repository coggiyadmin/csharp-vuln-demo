using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
public class BenignFlow : Controller {
  [HttpGet("/role")]
  public IActionResult Role() {
    HttpContext.Session.SetString("role", "user");
    return Ok("ok");
  }
}
