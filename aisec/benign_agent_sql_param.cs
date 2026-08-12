using System.Data.SqlClient;
public class BenignAgentSqlParam {
  public void Query(string id) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}
