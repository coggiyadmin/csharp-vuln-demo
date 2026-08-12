using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src03Cookie {
  public void Run(HttpRequest Request) {
    var id = Request.Cookies["uid"];
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
