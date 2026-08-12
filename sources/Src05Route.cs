using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src05Route {
  public void Run(HttpRequest Request) {
    var id = Request.RouteValues["id"]?.ToString();
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
