using System.Data.SqlClient;
public class Sk03ParameterizeSqliSafe {
  public void Run(string id) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}
