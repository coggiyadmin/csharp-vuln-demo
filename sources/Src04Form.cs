using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class Src04Form {
  public void Run(HttpRequest Request) {
    var id = Request.Form["id"];
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}
