using System.Data.SqlClient;
public class San03AliasHopSqliSafe {
  public void Run(string input) {
    var v = input;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", v);
  }
}
