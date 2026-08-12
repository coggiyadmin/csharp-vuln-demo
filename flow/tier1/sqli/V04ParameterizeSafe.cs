using System.Data.SqlClient;
public class V04ParameterizeSafe {
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", input);
  }
}
