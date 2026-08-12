using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
[ApiController]
[Route("api/[controller]")]
public class As01ControllerEntry : ControllerBase {
  [HttpGet("{id}")]
  public IActionResult Get(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
    return Ok();
  }
}
