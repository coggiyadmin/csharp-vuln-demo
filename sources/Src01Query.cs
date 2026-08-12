using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src01Query {
  public void Run(HttpRequest Request) {
    var id = Request.Query["id"];
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
