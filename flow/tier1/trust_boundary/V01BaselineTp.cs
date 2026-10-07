using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// Tier-1 trust_boundary — untrusted request → trusted session
public class V01BaselineTp : Controller {
  [HttpGet("/role")]
  public IActionResult Role([FromQuery] string role) {
    HttpContext.Session.SetString("role", role); // SINK CWE-501
    return Ok("ok");
  }
}
