using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src20Session {
  public void Run(HttpContext ctx) {
    var id = ctx.Session.GetString("uid");
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC session
  }
}
