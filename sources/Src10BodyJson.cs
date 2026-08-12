using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
public class Src10BodyJson : Controller {
  public class Body { public string Id { get; set; } }
  [HttpPost]
  public void Post([FromBody] Body b) {
    var q = "SELECT * FROM u WHERE id=" + b.Id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC body
  }
}
