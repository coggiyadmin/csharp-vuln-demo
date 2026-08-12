using System.Data.SqlClient;
public class Sk15PreparedStmtWrongTp {
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=" + id.Trim();
    var cmd = new SqlCommand(q, null); // SINK
  }
}
