using System.Data.SqlClient;
/** TN — parameterized SQL. */
public class BenignPreparedSql {
  public void Run(string id) {
    var cmd = new SqlCommand("SELECT name FROM users WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}
