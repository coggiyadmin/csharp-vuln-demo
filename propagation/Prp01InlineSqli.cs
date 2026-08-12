using System.Data.SqlClient;
public class Prp01InlineSqli {
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}
