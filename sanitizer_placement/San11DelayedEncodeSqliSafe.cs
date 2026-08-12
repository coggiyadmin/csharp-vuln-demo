using System.Data.SqlClient;
public class San11DelayedEncodeSqliSafe {
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", input);
  }
}
