using System.Data.SqlClient;
public class Sk15PreparedStmtSafe {
  public void Run(string id) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
    cmd.Prepare();
  }
}
