using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
/** channel — MVC controller. */
public class Ch02Controller : Controller {
  [HttpGet("/u")]
  public IActionResult Get([FromQuery] string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
    return Ok();
  }
}
