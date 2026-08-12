using System.Data.SqlClient;
public class San06ChainSqliSafe {
  public void Run(string input) {
    var v = input.Trim();
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", v);
  }
}
