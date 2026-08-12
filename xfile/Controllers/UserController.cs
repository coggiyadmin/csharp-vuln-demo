using Microsoft.AspNetCore.Mvc;
namespace Demo.Xfile.Controllers;
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase {
  readonly Services.UserQuery _q;
  public UserController(Services.UserQuery q) => _q = q;
  [HttpGet("{id}")]
  public IActionResult Get(string id) {
    _q.Lookup(id);
    return Ok();
  }
}
