using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src02Header {
  public void Run(HttpRequest Request) {
    var id = Request.Headers["X-User"];
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
